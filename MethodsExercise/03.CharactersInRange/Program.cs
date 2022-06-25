using System;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintCharsInBetween(firstChar,secondChar);
        }

        static void PrintCharsInBetween(char firstChar, char secondChar)
        {
            //if (secondChar < firstChar)
            //{
            //    char smallerChar = secondChar;
            //    secondChar = firstChar;
            //    firstChar = smallerChar;
            //}

            int startChar = Math.Min(firstChar, secondChar);
            int endChar = Math.Max(firstChar, secondChar);

            for (int i = startChar + 1; i < endChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
