using RestWithASPNETUdemy.Model;
using System;

namespace RestWithASPNETUdemy.Services.Implemetations
{
    public class PersonServiceImplemetation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {

        }

        public List<Person> FindAll(long id)
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                people.Add(person);
            }
            return people;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = InclementAndGet(),
                FirstName = "Thiago",
                LastName = "Moreira",
                Address = "Catanduva - São Paulo",
                Gender = "Male"
            };
        }



        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = InclementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Address = "Some Address" + i,
                Gender = "Male"
            };
        }
        private long InclementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

    }
}
