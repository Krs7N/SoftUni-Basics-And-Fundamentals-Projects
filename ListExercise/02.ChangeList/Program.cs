using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                switch (commands[0])
                {
                    case "Delete":
                        int element = int.Parse(commands[1]);
                        numbers.RemoveAll(el => el == element);
                        break;
                    case "Insert":
                        element = int.Parse(commands[1]);
                        int position = int.Parse(commands[2]);
                        numbers.Insert(position, element);
                        break;
                }

                commands = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
