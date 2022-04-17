using Microsoft.EntityFrameworkCore;

using EPortfolio.Models.Domain;

using System.Collections.Generic;
using System.Linq;

namespace EPortfolio.Data.Repositories
{
    public class MBTIRepository : IMBTIRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet <MBTI> _mbtis;

        public MBTIRepository (ApplicationDbContext context)
        {
            this._context = context;
            this._mbtis = context.MBTIs;
        }

        public IEnumerable <MBTI> GetAll ()
        {
            return _mbtis.AsNoTracking().OrderBy(m => m.Id).ToList();
        }

        public IEnumerable <MBTI> GetType (string type)
        {
            return _mbtis.Where(m => m.GiveEverything () == type)
                         .OrderBy(m => m.Id)
                         .ToList();
        }

        public MBTI GetById (int id)
        {
            return _mbtis.Where(m => m.Id == id)
                         .OrderBy(m => m.Id)
                         .FirstOrDefault();
        }

        public void Add (MBTI mbti)
        {
            this._mbtis.Add(mbti);
        }

        public void Delete (MBTI mbti)
        {
            this._mbtis.Remove(mbti);
        }

        public void SaveChanges ()
        {
            this._context.SaveChanges ();
        }
    }
}