using System;

namespace _07.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();

            string[] commands = Console.ReadLine().Split(":|:", StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "Reveal")
            {
                string action = commands[0];

                switch (action)
                {
                    case "InsertSpace":
                        int index = int.Parse(commands[1]);
                        concealedMessage = InsertSpace(concealedMessage, index);
                        break;
                    case "Reverse":
                        string substring = commands[1];
                        concealedMessage = Reverse(concealedMessage, substring);
                        break;
                    case "ChangeAll":
                        substring = commands[1];
                        string replacement = commands[2];
                        concealedMessage = ChangeAll(concealedMessage, substring, replacement);
                        break;
                }

                commands = Console.ReadLine().Split(":|:", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }

        static string InsertSpace(string concealedMessage, int index)
        {
            concealedMessage = concealedMessage.Insert(index, " ");
            Console.WriteLine(concealedMessage);

            return concealedMessage;
        }

        static string Reverse(string concealedMessage, string substring)
        {
            if (concealedMessage.Contains(substring))
            {
                int indexOfSubstring = concealedMessage.IndexOf(substring);
                concealedMessage = concealedMessage.Remove(indexOfSubstring, substring.Length);
                string reversed = string.Empty;

                for (int i = substring.Length - 1; i >= 0; i--)
                {
                    reversed += substring[i];
                }

                concealedMessage += reversed;

                Console.WriteLine(concealedMessage);
            }
            else
            {
                Console.WriteLine("error");
            }

            return concealedMessage;
        }

        static string ChangeAll(string concealedMessage, string substring, string replacement)
        {
            concealedMessage = concealedMessage.Replace(substring, replacement);

            Console.WriteLine(concealedMessage);

            return concealedMessage;
        }
    }
}
