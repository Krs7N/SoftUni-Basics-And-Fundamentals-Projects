using System;

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintMiddleChar(text);
        }

        static void PrintMiddleChar(string text)
        {
            if (text.Length % 2 == 0)
            {
                Console.Write(text[text.Length / 2 - 1]);
                Console.WriteLine(text[text.Length / 2]);
            }
            else
            {
                Console.WriteLine(text[text.Length / 2]);
            }
        }
    }
}
