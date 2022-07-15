using System;

namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string sentence = Console.ReadLine();

            while (sentence.Contains(wordToRemove))
            {
                sentence = sentence.Replace(wordToRemove, string.Empty);
            }

            Console.WriteLine(sentence);
        }
    }
}
