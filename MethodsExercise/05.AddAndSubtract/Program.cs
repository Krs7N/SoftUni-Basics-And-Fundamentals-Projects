using System;

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(GetSubtraction(GetSum(firstNumber, secondNumber), thirdNumber));
        }

        static int GetSum(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }

        static int GetSubtraction(int result, int thirdNumber)
        {
            return result - thirdNumber;
        }
    }
}
