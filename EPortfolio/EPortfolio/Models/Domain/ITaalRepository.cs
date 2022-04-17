using System.Collections.Generic;

namespace EPortfolio.Models.Domain
{
    public interface ITaalRepository
    {
        IEnumerable <Taal> GetAll ();
        IEnumerable <Taal> GetByName (string name);
        IEnumerable <Taal> GetByLevel (string level);

        Taal GetById (int id);

        void Add(Taal taal);
        void Delete(Taal taal);
        void SaveChanges();
    }
}