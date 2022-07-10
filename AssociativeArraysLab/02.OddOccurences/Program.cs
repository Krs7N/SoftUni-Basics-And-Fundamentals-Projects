using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(word => word.ToLower()).ToArray();

            Dictionary<string, int> oddWords = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!oddWords.ContainsKey(word))
                {
                    oddWords[word] = 0;
                }

                oddWords[word]++;
            }

            foreach (var oddWord in oddWords)
            {
                if (oddWord.Value % 2 != 0)
                {
                    Console.Write(oddWord.Key + " ");
                }
            }
        }
    }
}

