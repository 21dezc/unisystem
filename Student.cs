using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSystem
{
    public class Student
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public double Grade { get; set; }
        public Advisor Advisor { get; set; }

        public Student(string studentID, string firstName, string lastName, string major, double grade, Advisor advisor)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            Major = major;
            Grade = grade;
            Advisor = advisor;
        }
    }
}
