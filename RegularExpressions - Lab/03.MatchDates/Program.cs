using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>[0-3]\d)(?<separators>[.\-/])(?<month>[A-Z][a-z]{2})\k<separators>(?<year>\d{4})\b";

            string dates = Console.ReadLine();

            MatchCollection validDates = Regex.Matches(dates, pattern);

            foreach (Match validDate in validDates)
            {
                string day = validDate.Groups["day"].Value;
                string month = validDate.Groups["month"].Value;
                string year = validDate.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
