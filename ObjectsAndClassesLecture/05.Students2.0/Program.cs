using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Students2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string[] tokens = Console.ReadLine().Split();

            while (tokens[0] != "end")
            {
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];

                Student student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

                if (student == null )
                {
                    students.Add(new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown
                    });
                }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }

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
