using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            SortedDictionary<double, int> numbersByCount = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!numbersByCount.ContainsKey(number))
                {
                    numbersByCount.Add(number, 0);
                }

                numbersByCount[number]++;
            }

            foreach (KeyValuePair<double, int> number in numbersByCount)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
