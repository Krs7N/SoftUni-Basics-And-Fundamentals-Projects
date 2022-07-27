using System;

namespace _05.DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            char[] decryptedWord = new char[lines];

            for (int i = 0; i < lines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                char decryptedLetter = (char)(key + letter);
                decryptedWord[i] += decryptedLetter;
            }

            Console.WriteLine(decryptedWord);
        }
    }
}
