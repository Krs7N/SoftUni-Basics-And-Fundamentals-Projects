using System;
using System.Text;

namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(word);
                    Console.Write(sb);
                }
            }
        }
    }
}
