using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PersonBusiness
    {
        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            PersonData data = new PersonData();
            people = data.GetPeople();
            return people;
        }

        public List<Person> GetPeople18()
        {
            List<Person> people = new List<Person>();
            PersonData data = new PersonData();
            people = data.GetPeople();

            var resul = people.Where(x => x.Age > 18).ToList();
            return people;
        }
        public List<Person> GetPeopleByName(String name)
        {
            List<Person> people = new List<Person>();
            PersonData data = new PersonData();
            people = data.GetPeople();

            var resul = people.Where(x => x.FirstName.Contains(name)).ToList();
            return people;
        }
    }
}
