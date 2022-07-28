using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> passwordsByContests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> results = new Dictionary<string, Dictionary<string, int>>();

            string[] contestInfo = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);

            while (contestInfo[0] != "end of contests")
            {
                string contest = contestInfo[0];
                string password = contestInfo[1];

                passwordsByContests.Add(contest, password);

                contestInfo = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
            }

            string[] submissionInfo = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);

            while (submissionInfo[0] != "end of submissions")
            {
                string submissionContest = submissionInfo[0];
                string submissionPassword = submissionInfo[1];
                string username = submissionInfo[2];
                int pointsReceived = int.Parse(submissionInfo[3]);

                if (passwordsByContests.ContainsKey(submissionContest) && passwordsByContests[submissionContest] == submissionPassword)
                {
                    if (!results.ContainsKey(username))
                    {
                        results[username] = new Dictionary<string, int>();
                    }

                    if (results.ContainsKey(username) && !results[username].ContainsKey(submissionContest))
                    {
                        results[username][submissionContest] = 0;
                    }

                    if (results[username][submissionContest] < pointsReceived)
                    {
                        results[username][submissionContest] = pointsReceived;
                    }
                }

                submissionInfo = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            }

            string winner = results.OrderBy(x => x.Value.Values.Sum()).Last().Key;
            int bestPoints = results.OrderBy(x => x.Value.Values.Sum()).Last().Value.Values.Sum();

            Console.WriteLine($"Best candidate is {winner} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var item in results.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var contest in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
