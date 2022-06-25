using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);
                    arr = ExchangeArr(arr, index);
                }
                else if (command[0] == "max" || command[0] == "min")
                {
                    MinMax(arr, command[0], command[1]);
                }
                else
                {
                    Numbers(arr, command[0], int.Parse(command[1]), command[2]);
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        static int[] ExchangeArr(int[] arr, int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("Invalid index");
                return arr;
            }

            int[] exchangedArray = new int[arr.Length];
            int exchangedIndex = 0;
            for (int i = index + 1; i < arr.Length; i++)
            {
                exchangedArray[exchangedIndex] = arr[i];
                exchangedIndex++;
            }

            for (int i = 0; i <= index; i++)
            {
                exchangedArray[exchangedIndex] = arr[i];
                exchangedIndex++;
            }

            return exchangedArray;
        }

        static void MinMax(int[] arr, string minMax, string evenOdd)
        {
            int index = -1;
            int min = int.MaxValue;
            int max = int.MinValue;
            int result = 1;

            if (evenOdd == "even") result = 0;

            for (int currIndex = 0; currIndex < arr.Length; currIndex++)
            {
                if (arr[currIndex] % 2 == result)
                {
                    if (minMax == "min" && min >= arr[currIndex])
                    {
                        min = arr[currIndex];
                        index = currIndex;
                    }
                    else if (minMax == "max" && max <= arr[currIndex])
                    {
                        max = arr[currIndex];
                        index = currIndex;
                    }
                }
            }

            Console.WriteLine(index > -1 ? index.ToString() : "No matches");
        }

        static void Numbers(int[] arr, string position, int numbersTasked, string evenOdd)
        {
            if (numbersTasked > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (numbersTasked == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            int result = 1;
            if (evenOdd == "even") result = 0;

            int count = 0;

            List<int> nums = new List<int>();

            if (position == "first")
            {
                foreach (int num in arr)
                {
                    if (num % 2 == result)
                    {
                        count++;
                        nums.Add(num);
                    }

                    if (count == numbersTasked) break;
                }
            }
            else
            {
                for (int currIndex = arr.Length - 1; currIndex >= 0; currIndex--)
                {
                    if (arr[currIndex] % 2 == result)
                    {
                        count++;
                        nums.Add(arr[currIndex]);
                    }

                    if (count == numbersTasked) break;
                }
                nums.Reverse();
            }

            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }
    }
}
