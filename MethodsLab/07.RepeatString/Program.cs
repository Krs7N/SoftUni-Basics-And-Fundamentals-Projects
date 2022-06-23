using System;
using System.Runtime.ExceptionServices;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string biggerString = RepeatString(text, count);
            Console.WriteLine(biggerString);
        }

        static string RepeatString(string text, int count)
        {
            string result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                Console.Write(text);
            }

            return result;
        }
    }
}
