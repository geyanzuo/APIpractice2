using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIpractice2.Models;

namespace APIpractice2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        // GET: api/Subject
        [HttpGet]
        public IEnumerable<string> Get()
        {
            List<Subject> subject = new List<Subject>
            {
               new Subject(1234, "IT CertIV", "none")
            };

            List<string> subjectname = new List<string>();
            foreach (Subject su in subject)
            {
                subjectname.Add(su.SubjectName);
            }

            return subjectname;
        }

        // GET: api/Subject/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Subject
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Subject/5
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
