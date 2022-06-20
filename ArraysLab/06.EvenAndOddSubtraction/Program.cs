using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenSum = 0;
            int oddSum = 0;
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
                else
                {
                    oddSum += numbers[i];
                }
            }

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        evenSum += number;
            //    }
            //    else
            //    {
            //        oddSum += number;
            //    }
            //}

            result = evenSum - oddSum;
            Console.WriteLine(result);
        }
    }
}
