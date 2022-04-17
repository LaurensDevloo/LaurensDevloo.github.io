using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EPortfolio.Data
{
    public class DataInitializer
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager <IdentityUser> _userManager;

        public DataInitializer(ApplicationDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public async Task InitializeData()
        {

            /*
            _dbContext.Database.EnsureDeleted();
            if (_dbContext.Database.EnsureCreated())
            {
                await InitializeUsers();
                this.MakeEverything();
                _dbContext.SaveChanges();
            }
            */
        }

        private async Task InitializeUsers()
        {
            IdentityUser user = new IdentityUser { UserName = "admin@hogent.be", Email = "admin@hogent.be" };
            await _userManager.CreateAsync(user, "P@ssword1");
            await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, "admin"));

            user = new IdentityUser { UserName = "jan@hogent.be", Email = "jan@hogent.be" };
            await _userManager.CreateAsync(user, "P@ssword1");
            await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, "customer"));
        }

        private void MakeEverything ()
        {
        }
    }
}