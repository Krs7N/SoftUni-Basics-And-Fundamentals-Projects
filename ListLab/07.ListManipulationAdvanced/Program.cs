using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string[] commands = Console.ReadLine().Split();

            int numberIndex;

            bool isListChanged = false;

            while (commands[0] != "end")
            {
                switch (commands[0])
                {
                    case "Add":
                        numberIndex = int.Parse(commands[1]);
                        list.Add(numberIndex);
                        isListChanged = true;
                        break;
                    case "Remove":
                        numberIndex = int.Parse(commands[1]);
                        list.Remove(numberIndex);
                        isListChanged = true;
                        break;
                    case "RemoveAt":
                        numberIndex = int.Parse(commands[1]);
                        list.RemoveAt(numberIndex);
                        isListChanged = true;
                        break;
                    case "Insert":
                        numberIndex = int.Parse(commands[1]);
                        int index = int.Parse(commands[2]);
                        list.Insert(index, numberIndex);
                        isListChanged = true;
                        break;
                    case "Contains":
                        numberIndex = int.Parse(commands[1]);
                        Console.WriteLine(list.Contains(numberIndex) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        PrintEven(list);
                        break;
                    case "PrintOdd":
                        PrintOdd(list);
                        break;
                    case "GetSum":
                        int sum = GetSum(list);
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        int number = int.Parse(commands[2]);
                        Filter(list, commands[1], number);
                        break;
                }

                commands = Console.ReadLine().Split();
            }

            if (isListChanged)
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }

        static void PrintEven(List<int> list)
        {
            foreach (int number in list)
            {
                if (number % 2 == 0)
                {
                    Console.Write(number + " ");
                }
            }

            Console.WriteLine();
        }

        static void PrintOdd(List<int> list)
        {
            foreach (int number in list)
            {
                if (number % 2 != 0)
                {
                    Console.Write(number + " ");
                }
            }

            Console.WriteLine();
        }

        static int GetSum(List<int> list)
        {
            int sum = list.Sum();

            return sum;
        }

        static void Filter(List<int> list, string condition, int number)
        {
            switch (condition)
            {
                case "<":
                    foreach (int listNumber in list)
                    {
                        if (listNumber < number)
                        {
                            Console.Write(listNumber + " ");
                        }
                    }

                    Console.WriteLine();
                    break;
                case ">":
                    foreach (int listNumber in list)
                    {
                        if (listNumber > number)
                        {
                            Console.Write(listNumber + " ");
                        }
                    }

                    Console.WriteLine();
                    break;
                case ">=":
                    foreach (int listNumber in list)
                    {
                        if (listNumber >= number)
                        {
                            Console.Write(listNumber + " ");
                        }
                    }

                    Console.WriteLine();
                    break;
                case "<=":
                    foreach (int listNumber in list)
                    {
                        if (listNumber <= number)
                        {
                            Console.Write(listNumber + " ");
                        }
                    }

                    Console.WriteLine();
                    break;
            }
        }
    }
}
