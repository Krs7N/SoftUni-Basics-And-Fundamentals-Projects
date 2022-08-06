using System;
using System.Text.RegularExpressions;

namespace _14.EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patternForEmojis = @"(::|\*\*)(?<emojiName>[A-Z][a-z]{2,})\1";
            string patternForDigits = @"\d";

            long coolThreshold = 1;

            string input = Console.ReadLine();

            MatchCollection thresholdMatches = Regex.Matches(input, patternForDigits);
            MatchCollection emojisMatches = Regex.Matches(input, patternForEmojis);

            foreach (Match thresholdMatch in thresholdMatches)
            {
                coolThreshold *= int.Parse(thresholdMatch.Value);
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{emojisMatches.Count} emojis found in the text. The cool ones are:");

            foreach (Match emojiMatch in emojisMatches)
            {
                int coolness = 0;
                string emoji = emojiMatch.Groups["emojiName"].Value;

                for (int i = 0; i < emoji.Length; i++)
                {
                    coolness += emoji[i];
                }

                if (coolness > coolThreshold)
                {
                    Console.WriteLine(emojiMatch.Value);
                }
            }
        }
    }
}