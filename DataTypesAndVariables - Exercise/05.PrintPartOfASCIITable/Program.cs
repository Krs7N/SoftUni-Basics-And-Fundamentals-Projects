using System;

namespace _05.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startChar = int.Parse(Console.ReadLine());
            int endChar = int.Parse(Console.ReadLine());

            for (int i = startChar; i <= endChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
