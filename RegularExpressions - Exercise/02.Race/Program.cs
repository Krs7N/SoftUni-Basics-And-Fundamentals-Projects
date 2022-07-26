using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patternForName = @"(?<name>[A-Za-z])";
            string patternForKilometers = @"(?<kilometers>\d)";

            List<string> participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, int> participantsByKilometers = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                MatchCollection matchesForName = Regex.Matches(input, patternForName, RegexOptions.IgnoreCase);
                MatchCollection matchesForKilometers = Regex.Matches(input, patternForKilometers);

                StringBuilder curName = new StringBuilder();
                curName.AppendJoin("", matchesForName);
                StringBuilder curKilometers = new StringBuilder();
                curKilometers.AppendJoin("", matchesForKilometers);

                int sum = 0;
                for (int i = 0; i < curKilometers.Length; i++)
                {
                    int curDigit = int.Parse(curKilometers[i].ToString());
                    sum += curDigit;
                }

                if (participants.Contains(curName.ToString()) && !participantsByKilometers.ContainsKey(curName.ToString()))
                {
                    participantsByKilometers[curName.ToString()] = sum;
                }
                else if (participantsByKilometers.ContainsKey(curName.ToString()))
                {
                    participantsByKilometers[curName.ToString()] += sum;
                }

                input = Console.ReadLine();
            }

            var winners = participantsByKilometers.OrderByDescending(x => x.Value).Take(3);
            var firstPlace = winners.Take(1);
            var secondPlace = winners.Take(2).OrderBy(x => x.Value).Take(1);
            var thirdPlace = winners.OrderBy(x => x.Value).Take(1);

            foreach (var firstPlayer in firstPlace)
            {
                Console.WriteLine($"1st place: {firstPlayer.Key}");
            }

            foreach (var secondPlayer in secondPlace)
            {
                Console.WriteLine($"2nd place: {secondPlayer.Key}");
            }

            foreach (var thirdPlayer in thirdPlace)
            {
                Console.WriteLine($"3rd place: {thirdPlayer.Key}");
            }
        }
    }
}