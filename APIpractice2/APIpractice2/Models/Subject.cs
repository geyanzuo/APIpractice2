using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIpractice2.Models
{
    public class Subject
    {
        public int SubjectId;
        public string SubjectName;
        public string Description;

        public Subject(int subjectId, string subjectName, string description)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
            Description = description;
        }
    }
}
