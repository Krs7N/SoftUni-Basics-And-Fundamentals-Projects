using System;

namespace _13.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();

            string[] commands = Console.ReadLine().Split(">>>", StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "Generate")
            {
                string action = commands[0];

                switch (action)
                {
                    case "Contains":
                        Contains(commands[1], rawActivationKey);
                        break;
                    case "Flip":
                        rawActivationKey = Flip(commands[1], int.Parse(commands[2]), int.Parse(commands[3]), rawActivationKey);
                        break;
                    case "Slice":
                        rawActivationKey = Slice(int.Parse(commands[1]), int.Parse(commands[2]), rawActivationKey);
                        break;
                }

                commands = Console.ReadLine().Split(">>>", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }

        static void Contains(string substring, string rawActivationKey)
        {
            if (rawActivationKey.Contains(substring))
            {
                Console.WriteLine($"{rawActivationKey} contains {substring}");

                return;
            }

            Console.WriteLine("Substring not found!");
        }

        static string Flip(string upperOrLower, int startIndex, int endIndex, string activationKey)
        {
            string originalSubstring = activationKey.Substring(startIndex, endIndex - startIndex);

            if (upperOrLower == "Upper")
            {
                string uppedSubstring = activationKey.Substring(startIndex, endIndex - startIndex).ToUpper();
                activationKey = activationKey.Replace(originalSubstring, uppedSubstring);
            }
            else if (upperOrLower == "Lower")
            {
                string loweredSubstring = activationKey.Substring(startIndex, endIndex - startIndex).ToLower();
                activationKey = activationKey.Replace(originalSubstring, loweredSubstring);
            }

            Console.WriteLine(activationKey);

            return activationKey;
        }

        static string Slice(int startIndex, int endIndex, string activationKey)
        {
            activationKey = activationKey.Remove(startIndex, endIndex - startIndex);

            Console.WriteLine(activationKey);

            return activationKey;
        }
    }
}