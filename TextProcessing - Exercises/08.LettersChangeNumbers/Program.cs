using System;

namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] textsWithNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (var textWithNumbers in textsWithNumbers)
            {
                char firstLetter = textWithNumbers[0];
                double number = double.Parse(textWithNumbers.Substring(1, textWithNumbers.Length - 2));
                char lastLetter = textWithNumbers[textWithNumbers.Length - 1];

                GetResultOrSum(firstLetter, number, out int positionInAlphabet, out double result);

                sum = GetResultOrSum(sum, lastLetter, result, ref positionInAlphabet);
            }

            Console.WriteLine($"{sum:f2}");
        }

        public static double GetResultOrSum(char firstLetter, double number, out int positionInAlphabet, out double result)
        {
            if (char.IsUpper(firstLetter))
            {
                positionInAlphabet = firstLetter - 64;
                result = number / positionInAlphabet;
            }
            else
            {
                positionInAlphabet = firstLetter - 96;
                result = number * positionInAlphabet;
            }

            return result;
        }

        public static double GetResultOrSum(double sum, char lastLetter, double result, ref int positionInAlphabet)
        {
            if (char.IsUpper(lastLetter))
            {
                positionInAlphabet = lastLetter - 64;
                sum += result - positionInAlphabet;
            }
            else
            {
                positionInAlphabet = lastLetter - 96;
                sum += result + positionInAlphabet;
            }

            return sum;
        }
    }
}