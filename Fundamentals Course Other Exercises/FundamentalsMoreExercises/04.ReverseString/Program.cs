using System;

namespace _04.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int inputLength = input.Length - 1;

            for (int i = inputLength; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}
