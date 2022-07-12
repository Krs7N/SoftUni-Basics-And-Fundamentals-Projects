using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> countChars = new Dictionary<char, int>();

            char[] words = Console.ReadLine().ToCharArray();

            foreach (var word in words)
            {
                if (word != ' ')
                {
                    if (!countChars.ContainsKey(word))
                    {
                        countChars[word] = 0;
                    }

                    countChars[word]++;
                }
            }

            foreach (var letters in countChars)
            {
                Console.WriteLine($"{letters.Key} -> {letters.Value}");
            }
        }
    }
}
