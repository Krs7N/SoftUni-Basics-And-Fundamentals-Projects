using System;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int letters = int.Parse(Console.ReadLine());

            for (int i = 0; i < letters; i++)
            {
                for (int j = 0; j < letters; j++)
                {
                    for (int k = 0; k < letters; k++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + j);
                        char thirdChar = (char)('a' + k);
                        Console.Write($"{firstChar}{secondChar}{thirdChar}");
                        Console.WriteLine();
                    }
                }
            }
        
        }
    }
}
