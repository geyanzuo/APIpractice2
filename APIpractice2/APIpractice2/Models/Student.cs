using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIpractice2.Models
{
    public class Student
    {
        public int StudentId;
        public string FirstName;
        public string LastName;
        public Subject Enrollment;
        
        public Student()
        {

        }

        public Student(int v1, string v2, string v3)
        {
        }

        public Student(int studentId, string firstName, string lastName, Subject enrollment)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            Enrollment = enrollment;
        }
    }
}
