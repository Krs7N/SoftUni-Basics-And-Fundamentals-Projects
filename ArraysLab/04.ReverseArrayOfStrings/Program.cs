using System;

namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();

            for (int i = strings.Length - 1; i >= 0; i--) Console.Write(strings[i] + " ");
        }
    }
}
