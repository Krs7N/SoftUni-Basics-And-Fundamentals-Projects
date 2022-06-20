using System;
using System.Linq;

namespace _01.DaysOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayAsNumber = int.Parse(Console.ReadLine());

            string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", };

            if (dayAsNumber >= 1 && dayAsNumber <= 7)
            {
                Console.WriteLine(day[dayAsNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
