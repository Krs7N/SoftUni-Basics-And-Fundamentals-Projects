using System;

namespace _04.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string decryptedMessage = Console.ReadLine();

            string[] commands = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "Decode")
            {
                string action = commands[0];

                switch (action)
                {
                    case "Move":
                        decryptedMessage = Move(int.Parse(commands[1]), decryptedMessage);
                        break;
                    case "Insert":
                        decryptedMessage = Insert(int.Parse(commands[1]), commands[2], decryptedMessage);
                        break;
                    case "ChangeAll":
                        decryptedMessage = ChangeAll(commands[1], commands[2], decryptedMessage);
                        break;
                }

                commands = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"The decrypted message is: {decryptedMessage}");
        }

        static string Move(int numberOfLetters, string decryptedMessage)
        {
            string substringToAdd = decryptedMessage.Substring(0, numberOfLetters);
            
            decryptedMessage = decryptedMessage.Remove(0, numberOfLetters);
            decryptedMessage += substringToAdd;

            return decryptedMessage;
        }

        static string Insert(int index, string value, string decryptedMessage)
        {
            decryptedMessage = decryptedMessage.Insert(index, value);

            return decryptedMessage;
        }

        static string ChangeAll(string substring, string replacement, string decryptedMessage)
        {
            if (decryptedMessage.Contains(substring))
            {
                decryptedMessage = decryptedMessage.Replace(substring, replacement);
            }

            return decryptedMessage;
        }
    }
}
