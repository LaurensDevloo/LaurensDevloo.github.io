using System.Collections.Generic;

namespace EPortfolio.Models.Domain
{
    public interface IPersonRepository
    {
        IEnumerable <Person> GetAll ();
        IEnumerable <Person> GetByCity (string city);
        IEnumerable <Person> GetByPostcode (int postcode);
        IEnumerable <Person> GetByNameFirstname (string name, string firstname);
        IEnumerable <Person> GetByFirstName (string firstname);
        IEnumerable <Person> GetByName (string name);

        Person GetById (int id);

        void Add (Person person);
        void Delete (Person person);
        void SaveChanges ();
    }
}