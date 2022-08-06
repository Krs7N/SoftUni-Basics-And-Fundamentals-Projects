using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double withRemainingCourses = (double)persons / capacity;

            Console.WriteLine(Math.Ceiling(withRemainingCourses));
        }
    }
}
