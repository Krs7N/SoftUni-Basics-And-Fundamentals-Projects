using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([=|/])(?<destination>[A-Z][A-Za-z]{2,})\1";
            
            string destinations = Console.ReadLine();

            MatchCollection matches = Regex.Matches(destinations, pattern);

            int travelPoints = 0;

            List<string> matchedDestinations = new List<string>();  

            foreach (Match match in matches)
            {
                travelPoints += match.Groups["destination"].Value.Length;
                matchedDestinations.Add(match.Groups["destination"].Value);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", matchedDestinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
