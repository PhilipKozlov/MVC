using System.Collections.Generic;
using Views.Models;

namespace Views.Infrastructure
{
    public class PersonRepository
    {
        private IList<Person> persons;
        private static readonly PersonRepository instance;
 
        private PersonRepository()
        {
            this.persons = new List<Person>();
            this.persons.Add(new Person { Name = "John", Side = "Light" });
        }

        static PersonRepository()
        {
            instance = new PersonRepository();
        }

        public static PersonRepository Instance => instance;


        public void Add(Person person)
        {
            persons.Add(person);
        }

        public IList<Person> GetAll()
        {
            return persons;
        }
    }
}