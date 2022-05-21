using System;

namespace _03.PassedOrFailed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine(grade >= 3 ? "Passed!" : "Failed!");
        }
    }
}
