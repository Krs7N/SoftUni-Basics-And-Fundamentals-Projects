using System;
using System.Linq;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Where(username => username.All(ch => ch == '_' || ch == '-' || char.IsLetterOrDigit(ch)) && username.Length >= 3 && username.Length <= 16).ToArray();

            Console.WriteLine(string.Join('\n', usernames));

            //foreach (var username in usernames)
            //{
            //    for (int i = 0; i < username.Length; i++)
            //    {
            //        char currentChar = username[i];
            //        if (!(currentChar == '_' || currentChar == '-' || char.IsLetterOrDigit(currentChar)))
            //        {
            //            break;
            //        }

            //        if (i == username.Length - 1)
            //        {
            //            Console.WriteLine(username);
            //        }
            //    }
            //}
        }
    }
}
