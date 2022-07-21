using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> sequenceOfLetters = Console.ReadLine().ToList();

            for (int i = 0; i < sequenceOfLetters.Count - 1; i++)
            {
                if (sequenceOfLetters[i] == sequenceOfLetters[i + 1])
                {
                    sequenceOfLetters.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join("", sequenceOfLetters));
        }
    }
}
