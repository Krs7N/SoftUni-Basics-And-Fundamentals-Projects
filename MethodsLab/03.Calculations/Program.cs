using System;
using System.ComponentModel;

namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mathOperation = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            switch (mathOperation)
            {
                case "add":
                    Add(number, secondNumber);
                    break;
                case "multiply":
                    Multiply(number, secondNumber);
                    break;
                case "subtract":
                    Subtract(number, secondNumber);
                    break;
                case "divide":
                    Divide(number, secondNumber);
                    break;
            }
        }

        static void Add(int number, int secondNumber)
        {
            Console.WriteLine(number + secondNumber);
        }

        static void Multiply(int number, int secondNumber)
        {
            Console.WriteLine(number * secondNumber);
        }

        static void Subtract(int number, int secondNumber)
        {
            Console.WriteLine(number - secondNumber);
        }

        static void Divide(int number, int secondNumber)
        {
            Console.WriteLine(number / secondNumber);
        }

    }
}
