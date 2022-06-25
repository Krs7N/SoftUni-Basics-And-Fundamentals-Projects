using System;

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            PrintSmallestNumber(firstNumber, secondNumber, thirdNumber);
        }

        static void PrintSmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int smallerNumber = Math.Min(firstNumber, secondNumber);
            int result = Math.Max(smallerNumber, thirdNumber);

            Console.WriteLine(result);
        }
    }
}
