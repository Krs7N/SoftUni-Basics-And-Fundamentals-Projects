using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string[] tokens = Console.ReadLine().Split();

            while (tokens[0] != "End")
            {
                switch (tokens[0])
                {
                    case "Add":
                        int number = int.Parse(tokens[1]);
                        numbers.Add(number);
                        break;
                    case "Insert":
                        number = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        if (index < 0 || index > numbers.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.Insert(index, number);
                        break;
                    case "Remove":
                        index = int.Parse(tokens[1]);
                        if (index < 0 || index > numbers.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.RemoveAt(index);
                        break;
                    case "Shift":
                        int count = int.Parse(tokens[2]);
                        if (tokens[1] == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Add(numbers[0]);
                                numbers.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Insert(0, numbers[numbers.Count - 1]);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }
                        break;
                }

                tokens = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
