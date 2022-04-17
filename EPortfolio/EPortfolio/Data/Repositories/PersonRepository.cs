using Microsoft.EntityFrameworkCore;

using EPortfolio.Models.Domain;

using System.Collections.Generic;
using System.Linq;

namespace EPortfolio.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet <Person> _persons;

        public PersonRepository (ApplicationDbContext context)
        {
            _context = context;
            _persons = context.Persons;
        }

        public IEnumerable <Person> GetAll ()
        {
            return _persons.AsNoTracking()
                           .OrderBy(p => p.Name)
                           .ThenBy(p => p.FirstName)
                           .ToList();
        }

        public IEnumerable <Person> GetByCity (string city)
        {
            return _persons.Where(p => p.City == city)
                           .OrderBy(p => p.Name)
                           .ThenBy(p => p.FirstName)
                           .ToList();
        }

        public IEnumerable <Person> GetByPostcode (int postcode)
        {
            return _persons.Where(p => p.Postcode == postcode)
                           .OrderBy(p => p.Name)
                           .ThenBy(p => p.FirstName)
                           .ToList();
        }

        public IEnumerable <Person> GetByFirstName (string firstname)
        {
            return _persons.Where(p => p.FirstName == firstname)
                           .OrderBy(p => p.Name)
                           .ToList();
        }

        public IEnumerable <Person> GetByNameFirstname (string name, string firstname)
        {
            return _persons.Where(p => (p.FirstName == firstname) && (p.Name == name))
                           .OrderBy(p => p.Name)
                           .ToList();
        }

        public IEnumerable <Person> GetByName (string name)
        {
            return _persons.Where(p => p.Name == name)
                           .OrderBy(p => p.Name)
                           .ToList();
        }

        public Person GetById (int id)
        {
            return _persons.Where(p => p.Id == id)
                           .OrderBy(p => p.Name)
                           .FirstOrDefault();
        }

        public void Add (Person person)
        {
            this._persons.Add(person);
        }

        public void Delete (Person person)
        {
            this._persons.Remove(person);
        }

        public void SaveChanges ()
        {
            _context.SaveChanges ();
        }
    }
}