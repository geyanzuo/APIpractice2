using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIpractice2.Models;
using System.Data.SqlClient;

namespace APIpractice2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        List<Student> student = new List<Student>
        {
            new Student(1111, "Charlie", "Ge"),
            new Student(2222, "Roland", "None")
        };

        List<Subject> subject = new List<Subject>
        {
            new Subject(1234, "T-SQL", "intro to T-SQL")
        };


        // GET: api/Enrollment
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            SqlConnection connection = new SqlConnection("Server=tcp:civapi.database.windows.net,1433;Initial Catalog=civapi;User ID=civ_user;Password=Monday1330;");


            string query = "Select * From StuDent";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader result = command.ExecuteReader();

            List<Student> students = new List<Student>();

            while (result.Read())
            {
                student.Add(new Student(int.Parse(result[0].ToString()),result[1].ToString(), result[2].ToString()));
            }

            connection.Close();

            return students;
        }

        // GET: api/Enrollment/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Enrollment
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Enrollment/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
