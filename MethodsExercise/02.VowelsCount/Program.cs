using System;
using System.Linq;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            PrintVowels(text);
        }

        static void PrintVowels(string text)
        {
            int count = 0;
            //Console.WriteLine(text.Count(vowels => "aouei".Contains(vowels)));
            foreach (char vowel in text.ToLower())
            {
                if ("aouei".Contains(vowel))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
