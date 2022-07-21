using System;
using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();

            StringBuilder encryptedText = new StringBuilder();

            for (int i = 0; i < sentence.Length; i++)
            {
                char encryptedChar = (char)(sentence[i] + 3);
                encryptedText.Append(encryptedChar);
            }

            Console.WriteLine(encryptedText);
        }
    }
}
