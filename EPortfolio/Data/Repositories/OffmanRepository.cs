using Microsoft.EntityFrameworkCore;

using EPortfolio.Models.Domain;

using System.Collections.Generic;
using System.Linq;

namespace EPortfolio.Data.Repositories
{
    public class OffmanRepository : IOffmanRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet <Offman> _offmans;

        public OffmanRepository (ApplicationDbContext context)
        {
            this._context = context;
            this._offmans = context.Offmans;
        }

        public IEnumerable <Offman> GetAll ()
        {
            return _offmans.AsNoTracking().OrderBy(o => o.CoreQuality).ToList();
        }

        public IEnumerable <Offman> GetByAllergy (string allergy)
        {
            return this._offmans.Where(o => o.Allergy == allergy)
                                .OrderBy(o => o.CoreQuality)
                                .ToList();
        }

        public IEnumerable <Offman> GetByChallenge (string challenge)
        {
            return this._offmans.Where(o => o.Challenge == challenge)
                                .OrderBy(o => o.CoreQuality)
                                .ToList();
        }

        public IEnumerable <Offman> GetByCoreQuality (string coreQuality)
        {
            return this._offmans.Where(o => o.CoreQuality == coreQuality)
                                .OrderBy(o => o.CoreQuality)
                                .ToList();
        }

        public IEnumerable <Offman> GetByPitfall (string pitfall)
        {
            return this._offmans.Where(o => o.Pitfall == pitfall)
                                .OrderBy(o => o.CoreQuality)
                                .ToList();
        }

        public Offman GetById (int id)
        {
            return _offmans.Where(o => o.Id == id)
                           .OrderBy(o => o.CoreQuality)
                           .FirstOrDefault();
        }

        public void Add (Offman offman)
        {
            this._offmans.Add(offman);
        }

        public void Delete (Offman offman)
        {
            this._offmans.Remove(offman);
        }

        public void SaveChanges ()
        {
            this._context.SaveChanges ();
        }
    }
}