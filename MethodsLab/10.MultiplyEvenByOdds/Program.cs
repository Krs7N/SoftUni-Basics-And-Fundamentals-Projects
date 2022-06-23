using System;

namespace _10.MultiplyEvenByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMultipleOfEvenAndOdds(Math.Abs(number)));
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int result = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);

            return result;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
            }

            return evenSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 != 0)
                {
                    oddSum += digit;
                }
            }

            return oddSum;
        }
    }
}
