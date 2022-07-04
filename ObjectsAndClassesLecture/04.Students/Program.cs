using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string[] tokens = Console.ReadLine().Split();

            while (tokens[0] != "end")
            {
                Student student = new Student(tokens[0], tokens[1], int.Parse(tokens[2]), tokens[3]);

                students.Add(student);

                tokens = Console.ReadLine().Split();
            }

            string cityName = Console.ReadLine();

            List<Student> studentsByCity = students.Where(student => student.HomeTown == cityName).ToList();

            foreach (Student student in studentsByCity)
            {
                Console.WriteLine(student);
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}
