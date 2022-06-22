using System;
using System.Linq;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] peopleInWagon = new int[wagons];

            int sum = 0;

            for (int i = 0; i < wagons; i++)
            {
                peopleInWagon[i] = int.Parse(Console.ReadLine());
                sum += peopleInWagon[i];
            }

            Console.WriteLine(string.Join(" ", peopleInWagon));
            Console.WriteLine(sum);
        }
    }
}