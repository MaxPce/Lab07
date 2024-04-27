using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PersonData
    {
        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();

            string connectionString = "Data Source=LAB1504-32\\SQLEXPRESS; Initial Catalog=FacturaDB;User Id=user01; Password=123456";

            string query = "SELECT PersonId, FirstName, LastName, Age FROM People";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Person person = new Person
                            {
                                PersonId = Convert.ToInt32(reader["PersonId"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Age = Convert.ToInt32(reader["Age"])
                            };
                            people.Add(person);
                        }
                    }
                }
            }

            return people;
        }

        public void Insert()
        { 

        }
        public void Update()
        {

        }
        public void Delete()
        {

        }
    }
}
