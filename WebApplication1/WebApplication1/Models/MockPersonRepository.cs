using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MockPersonRepository : IPersonRepository
    {
        private List<Person> _person;

        public IEnumerable<Person> GetAllPerson()
        {
            return _person;
        }

        public Person GetPersonById(string PersonId)
        {
            return _person.FirstOrDefault(p => p.PersonId == PersonId);
        }


        public MockPersonRepository()
        {
            if(_person == null)
            {
                InitializePerson();

            }
        }

        private void InitializePerson()
        {
            _person = new List<Person>
            {

                 new Person { PersonId = "100001", LastName = "Angeles", FirstName = "Archimedes", Address = "San Isidro, Nueva Ecija"},

                  new Person { PersonId = "100002", LastName = "Angeles", FirstName = "Alexander", Address = "San Isidro, Nueva Ecija"},

                  new Person { PersonId = "100003", LastName = "Angeles", FirstName = "Anabelle", Address = "San Isidro, Nueva Ecija"}

            };
        }
    }
}
