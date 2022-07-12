using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> gradesByStudents = new Dictionary<string, List<double>>();

            int inputsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputsCount; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!gradesByStudents.ContainsKey(studentName))
                {
                    gradesByStudents[studentName] = new List<double>();
                }

                gradesByStudents[studentName].Add(grade);
            }

            foreach (var gradeByStudent in gradesByStudents)
            {
                string name = gradeByStudent.Key;
                List<double> grade = gradeByStudent.Value;

                if (grade.Average() >= 4.50)
                {
                    Console.WriteLine($"{name} -> {grade.Average():f2}");
                }
            }
        }
    }
}
