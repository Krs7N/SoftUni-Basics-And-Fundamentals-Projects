using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensedNums = new int[numbers.Length - 1];

            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }

            while (numbers.Length != 1)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    condensedNums[i] = numbers[i] + numbers[i + 1];

                    if (i == numbers.Length - 2)
                    {
                        numbers = condensedNums;
                        condensedNums = new int[numbers.Length - 1];
                    }
                }
            }

            Console.WriteLine(numbers[0]);  
        }
    }
}
