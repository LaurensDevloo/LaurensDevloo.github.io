using Microsoft.EntityFrameworkCore;

using EPortfolio.Models.Domain;

using System.Collections.Generic;
using System.Linq;

namespace EPortfolio.Data.Repositories
{
    public class TaalRepository: ITaalRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet <Taal> _talen;

        public TaalRepository (ApplicationDbContext context)
        {
            this._context = context;
            this._talen = this._context.Talen;
        }

        public IEnumerable <Taal> GetAll ()
        {
            return this._talen.AsNoTracking().OrderBy(t => t.Naam).ToList();
        }

        public IEnumerable <Taal> GetByLevel (string level)
        {
            return this._talen.Where(t => t.Niveau == level)
                       .OrderBy(t => t.Naam)
                       .ToList();
        }

        public IEnumerable <Taal> GetByName (string name)
        {
            return this._talen.Where(t => t.Naam == name)
                       .OrderBy(t => t.Naam)
                       .ToList();
        }

        public Taal GetById (int id)
        {
            return this._talen.Where(t => t.Id == id).OrderBy(t => t.Naam).FirstOrDefault();
        }

        public void Add (Taal taal)
        {
            this._talen.Add(taal);
        }

        public void Delete (Taal taal)
        {
            this._talen.Remove(taal);
        }

        public void SaveChanges ()
        {
            this._context.SaveChanges ();
        }
    }
}