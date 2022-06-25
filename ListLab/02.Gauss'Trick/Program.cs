using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int i = 0; i < list.Count - 1; i++)
            {
                list[i] += list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
