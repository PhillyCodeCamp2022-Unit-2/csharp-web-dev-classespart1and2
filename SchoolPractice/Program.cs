using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student student1 = new Student("Tom", 8, 1, 4.0);
            //Console.WriteLine($"Name: {student1.Name}");
            //Console.WriteLine($"ID: {student1.StudentId}");
            //Console.WriteLine($"Credits: {student1.NumberOfCredits}");
            //Console.WriteLine($"GPA: {student1.Gpa}");

            Student student2 = new Student("Jenell", 4, 1, 4.0);
            Student student3 = new Student("Francesca", 5, 1, 4.0);

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            Course latin = new Course("Latin 101", "Professor Bourdegard", students);
            Console.WriteLine($"Name: {latin.Name}");
            Console.WriteLine($"Professor: {latin.ProfessorName}");
            Console.WriteLine($"Roster:");
            foreach (Student student in latin.StudentRoster)
            {
                Console.WriteLine("---------");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"ID: {student.StudentId}");
                Console.WriteLine($"Credits: {student.NumberOfCredits}");
                Console.WriteLine($"GPA: {student.Gpa}");
                Console.WriteLine("---------");
            }
        }
    }
}
