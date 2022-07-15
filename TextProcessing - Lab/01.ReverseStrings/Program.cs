using System;
using System.Collections.Generic;

namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                words.Add(input);

                input = Console.ReadLine();
            }

            foreach (var word in words)
            {
                string reversedWord = string.Empty;

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord += word[i];
                }

                Console.WriteLine($"{word} = {reversedWord}");
            }

            //string word = Console.ReadLine();

            //while (word != "end")
            //{
            //    string reversedWord = string.Empty;

            //    for (int i = word.Length - 1; i >= 0; i--)
            //    {
            //        reversedWord += word[i];
            //    }

            //    Console.WriteLine($"{word} = {reversedWord}");

            //    word = Console.ReadLine();
            //}
        }
    }
}
