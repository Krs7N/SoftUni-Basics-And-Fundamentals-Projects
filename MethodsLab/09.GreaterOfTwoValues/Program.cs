using System;
using System.Runtime.ExceptionServices;

namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            switch (dataType)
            {
                case "int":
                    int firstNum = int.Parse(Console.ReadLine());
                    int secondNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstNum, secondNum));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstChar, secondChar));
                    break;
                case "string":
                    string firstText = Console.ReadLine();
                    string secondText = Console.ReadLine();
                    Console.WriteLine(GetMax(firstText, secondText));
                    break;
            }
        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }

            return secondNumber;
        }

        static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }

            return secondChar;
        }

        static string GetMax(string firstText, string secondText)
        {
            int result = firstText.CompareTo(secondText);
            if (result > 0)
            {
                return firstText;
            }

            return secondText;
        }
    }
}
