using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _08.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"([@|#])(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";

            var wordsByMirrorWords = new List<string>();

            MatchCollection matches = Regex.Matches(text, pattern);

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");

                return;
            }

            Console.WriteLine($"{matches.Count} word pairs found!");

            foreach (Match match in matches)
            {
                string firstWord = match.Groups["firstWord"].Value;
                string secondWord = match.Groups["secondWord"].Value;
                string finalPair = string.Empty;
                string reversedWord = string.Empty;

                for (int i = secondWord.Length - 1; i >= 0; i--)
                {
                    reversedWord += secondWord[i];
                }

                if (firstWord == reversedWord)
                {
                    finalPair = $"{firstWord} <=> {secondWord}";
                    wordsByMirrorWords.Add(finalPair);
                }
            }

            if (wordsByMirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");

                return;
            }

            Console.WriteLine("The mirror words are:");
            Console.WriteLine(string.Join(", ", wordsByMirrorWords));
        }
    }
}