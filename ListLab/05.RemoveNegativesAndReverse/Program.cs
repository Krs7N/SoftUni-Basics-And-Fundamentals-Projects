using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();


            list.RemoveAll(num => num < 0);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] < 0)
            //    {
            //        list.RemoveAt(i);
            //        i--;
            //    }
            //}

            if (list.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            list.Reverse();

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
