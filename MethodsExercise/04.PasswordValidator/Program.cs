using System;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            int digitCount = 0;
            bool isLengthCorrect = CheckPasswordLength(password);
            bool isLetterOrDigit = CheckPasswordChars(password);
            bool isAtLeastTwoDigits = CheckPasswordDigits(password, digitCount);

            if (!isLengthCorrect)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isLetterOrDigit)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!isAtLeastTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isAtLeastTwoDigits && isLengthCorrect && isLetterOrDigit)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CheckPasswordLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }

        static bool CheckPasswordChars(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }

            return true;
        }

        static bool CheckPasswordDigits(string password, int digitCount)
        {
            digitCount = 0;

            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    digitCount++;
                }
            }

            return digitCount >= 2;
        }
    }
}
