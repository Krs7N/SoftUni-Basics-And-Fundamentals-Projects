using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string[] commands = Console.ReadLine().Split();

            int numberIndex;

            while (commands[0] != "end")
            {
                switch (commands[0])
                {
                    case "Add":
                        numberIndex = int.Parse(commands[1]);
                        list.Add(numberIndex);
                        break;
                    case "Remove":
                        numberIndex = int.Parse(commands[1]);
                        list.Remove(numberIndex);
                        break;
                    case "RemoveAt":
                        numberIndex = int.Parse(commands[1]);
                        list.RemoveAt(numberIndex);
                        break;
                    case "Insert":
                        numberIndex = int.Parse(commands[1]);
                        int index = int.Parse(commands[2]);
                        list.Insert(index, numberIndex);
                        break;
                }

                commands = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
