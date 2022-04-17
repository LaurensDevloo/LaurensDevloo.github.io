using System.Collections.Generic;

namespace EPortfolio.Models.Domain
{
    public interface IOffmanRepository
    {
        IEnumerable <Offman> GetAll ();
        IEnumerable <Offman> GetByCoreQuality (string coreQuality);
        IEnumerable <Offman> GetByPitfall (string pitfall);
        IEnumerable <Offman> GetByChallenge (string challenge);
        IEnumerable <Offman> GetByAllergy (string allergy);

        Offman GetById (int id);

        void Add (Offman offman);
        void Delete (Offman offman);
        void SaveChanges ();
    }
}