using System;

namespace _05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int messageInputs = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < messageInputs; i++)
            {
                string digits = Console.ReadLine();
                int digitsCopy = int.Parse(digits);
                int digitLength = digits.Length;
                int digit = digitsCopy % 10;
                int offset = (digit - 2) * 3;

                if (digit == 0)
                {
                    message += (char)(digit + 32);
                    continue;
                }

                if (digit == 7 || digit == 9)
                {
                    offset++;
                }

                int letterIndex = offset + digitLength - 1;
                message += (char)(letterIndex + 97);
            }

            Console.WriteLine(message);
        }
    }
}
