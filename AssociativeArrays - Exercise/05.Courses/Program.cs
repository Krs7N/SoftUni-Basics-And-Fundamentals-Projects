using System;
using System.Collections.Generic;
using System.Net.Http;

namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> studentsByCourses = new Dictionary<string, List<string>>();

            string[] information = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);

            while (information[0] != "end")
            {
                string courseName = information[0];
                string studentName = information[1];

                if (!studentsByCourses.ContainsKey(courseName))
                {
                    studentsByCourses[courseName] = new List<string>();
                }
                studentsByCourses[courseName].Add(studentName);

                information = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var kvp in studentsByCourses)
            {
                string studentName = kvp.Key;
                List<string> studentsCount = kvp.Value;
                Console.WriteLine($"{studentName}: {studentsCount.Count}");
                foreach (var students in studentsCount)
                {
                    Console.WriteLine($"-- {students}");
                }

            }
        }
    }
}
