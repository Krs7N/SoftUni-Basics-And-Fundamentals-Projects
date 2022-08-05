using System;

namespace _10.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "Done")
            {
                string action = commands[0];

                switch (action)
                {
                    case "TakeOdd":
                        password = TakeOdd(password);
                        break;
                    case "Cut":
                        password = Cut(password, int.Parse(commands[1]), int.Parse(commands[2]));
                        break;
                    case "Substitute":
                        password = Substitute(password, commands[1], commands[2]);
                        break;
                }

                commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"Your password is: {password}");
        }

        private static string TakeOdd(string password)
        {
            string newPassword = string.Empty;
            for (int i = 1; i < password.Length; i += 2)
            {
                newPassword += password[i];
            }

            password = newPassword;

            Console.WriteLine(password);

            return password;
        }

        static string Cut(string password, int index, int length)
        {
            password = password.Remove(index, length);

            Console.WriteLine(password);

            return password;
        }

        static string Substitute(string password, string substring, string substitute)
        {
            if (password.Contains(substring))
            {
                password = password.Replace(substring, substitute);
                Console.WriteLine(password);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }

            return password;
        }
    }
}
