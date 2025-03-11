using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UniSystem
{
    public class Advisor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public List<Student> Students { get; set; } // รายชื่อนักศึกษาของอาจารย์

        public Advisor(string firstName, string lastName, string major)
        {
            FirstName = firstName;
            LastName = lastName;
            Major = major;
            Students = new List<Student>(); // สร้างรายชื่อนักศึกษา
        }

        public void AddStudent(Student student)
        {
            Students.Add(student); // เพิ่มนักศึกษาลงในรายชื่อนักศึกษา
        }
    }

}
