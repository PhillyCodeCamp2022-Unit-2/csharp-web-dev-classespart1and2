using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student student1 = new Student("Tom", 8, 1, 4.0);
            Console.WriteLine($"Name: {student1.Name}");
            Console.WriteLine($"ID: {student1.StudentId}");
            Console.WriteLine($"Credits: {student1.NumberOfCredits}");
            Console.WriteLine($"GPA: {student1.Gpa}");
        }
    }
}
