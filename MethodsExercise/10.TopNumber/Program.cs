using System;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            TopNumber(endNumber);
        }

        static void TopNumber(int endNumber)
        {
            for (int number = 1; number <= endNumber; number++)
            {
                if (number >= 1 && number <= 9)
                {
                    continue;
                }

                int numberCopy = number;

                bool isDigitOdd = true;
                int sum = 0;

                while (numberCopy > 0)
                {
                    int digit = numberCopy % 10;
                    sum += digit;
                    numberCopy /= 10;

                    if (digit % 2 != 0 && isDigitOdd)
                    {
                        isDigitOdd = false;
                    }
                }

                if (sum % 8 == 0 && isDigitOdd == false)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
