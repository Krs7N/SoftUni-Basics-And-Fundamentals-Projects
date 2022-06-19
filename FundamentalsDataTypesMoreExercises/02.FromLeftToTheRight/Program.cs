using System;
using System.Linq;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            long sum = 0;

            for (int i = 0; i < lines; i++)
            {
                long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();

                long biggerNumber = Math.Abs(Math.Max(numbers[0], numbers[1]));

                while (biggerNumber > 0)
                {
                    long digit = biggerNumber % 10;
                    sum += digit;
                    biggerNumber /= 10;
                }

                Console.WriteLine(sum);

                sum = 0;
            }
        }
    }
}
