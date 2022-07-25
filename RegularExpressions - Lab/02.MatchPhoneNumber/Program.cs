using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359(?<separators>[ -])2\k<separators>\d{3}\k<separators>\d{4}\b";

            string phones = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phones, pattern);

            Console.WriteLine(string.Join(", ", phoneMatches));
        }
    }
}
