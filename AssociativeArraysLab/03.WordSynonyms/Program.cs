using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> synonymsByWord = new Dictionary<string, List<string>>();

            int numberOfWords = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfWords; i++)
            {
                string mainWord = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonymsByWord.ContainsKey(mainWord))
                {
                    synonymsByWord[mainWord] = new List<string>();
                }

                synonymsByWord[mainWord].Add(synonym);
            }

            foreach (var words in synonymsByWord)
            {
                Console.Write($"{words.Key} - ");
                Console.WriteLine(string.Join(", ", words.Value));
            }
        }
    }
}
