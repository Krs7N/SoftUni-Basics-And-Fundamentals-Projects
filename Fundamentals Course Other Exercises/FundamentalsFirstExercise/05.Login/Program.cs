using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int usernameLength = username.Length - 1;
            string password = "";

            for (int i = usernameLength; i >= 0; i--)
            {
                password += username[i];
            }

            int wrongPasswords = 0;
            string inputPassword = Console.ReadLine();

            while (inputPassword != password)
            {
                wrongPasswords++;
                if (wrongPasswords == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                inputPassword = Console.ReadLine();
            }

            if (inputPassword == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
