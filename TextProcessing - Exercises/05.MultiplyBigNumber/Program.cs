using System;
using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            if (number == 0 || bigNumber == "0")
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder sb = new StringBuilder();
            int remainder = 0;

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                char lastNumber = bigNumber[i];
                int lastNumAsDigit = int.Parse(lastNumber.ToString());

                int result = lastNumAsDigit * number + remainder;

                sb.Append(result % 10);

                remainder = result / 10;
            }

            if (remainder != 0)
            {
                sb.Append(remainder);
            }

            StringBuilder reversedNumber = new StringBuilder();

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                reversedNumber.Append(sb[i]);
            }

            Console.WriteLine(reversedNumber);
        }
    }
}
