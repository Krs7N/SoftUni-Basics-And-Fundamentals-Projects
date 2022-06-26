using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string[] tokens = Console.ReadLine().Split();

            while (tokens[0] != "end")
            {
                if (tokens[0] == "Add")
                {
                    int passengers = int.Parse(tokens[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(tokens[0]);
                    FindFreeWagon(wagons, maxCapacity, passengers);
                }

                tokens = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }

        static void FindFreeWagon(List<int> wagons, int maxCapacity, int passengers)
        {
            for (int i = 0; i < wagons.Count ; i++)
            {
                if (wagons[i] + passengers <= maxCapacity)
                {
                    wagons[i] += passengers;
                    break;
                }
            }
        }
    }
}
