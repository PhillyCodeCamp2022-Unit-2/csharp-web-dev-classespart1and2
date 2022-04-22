using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    internal class Course
    {
        public string Name { get; set; }
        public string ProfessorName { get; set; }
        public List<Student> StudentRoster { get; set; }

        public Course(string name, string professor, List<Student> roster) 
        {
            Name = name;
            ProfessorName = professor;
            StudentRoster = roster;
        }
    }
}
