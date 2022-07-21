using System;

namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(CharMultiplier(strings[0], strings[1]));
        }

        public static int CharMultiplier(string firstString, string secondString)
        {
            int sum = 0;

            string longerString = string.Empty;
            string shorterString = string.Empty;


            if (firstString.Length > secondString.Length)
            {
                longerString = firstString;
                shorterString = secondString;
            }
            else
            {
                shorterString = firstString;
                longerString = secondString;
            }

            for (int i = 0; i < shorterString.Length; i++)
            {
                sum += shorterString[i] * longerString[i];
            }

            for (int i = shorterString.Length; i < longerString.Length; i++)
            {
                sum += longerString[i];
            }

            return sum;
        }
    }
}
