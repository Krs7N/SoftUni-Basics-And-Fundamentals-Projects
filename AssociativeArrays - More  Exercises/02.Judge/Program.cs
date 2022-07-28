using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contestByUsernameAndPoints = new Dictionary<string, Dictionary<string, int>>();
            var usernameByTotalPoints = new SortedDictionary<string, int>();

            string[] judgeInfo = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

            while (judgeInfo[0] != "no more time")
            {
                string username = judgeInfo[0];
                string contest = judgeInfo[1];
                int points = int.Parse(judgeInfo[2]);

                if (!contestByUsernameAndPoints.ContainsKey(contest))
                {
                    contestByUsernameAndPoints.Add(contest, new Dictionary<string, int>());
                    contestByUsernameAndPoints[contest].Add(username, points);
                }
                else
                {
                    if (!contestByUsernameAndPoints[contest].ContainsKey(username))
                    {
                        contestByUsernameAndPoints[contest].Add(username, points);
                    }
                    else
                    {
                        if (contestByUsernameAndPoints[contest][username] < points)
                        {
                            contestByUsernameAndPoints[contest][username] = points;
                        }
                    }
                }

                judgeInfo = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var contest in contestByUsernameAndPoints)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                int placement = 1;
                foreach (var participant in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{placement}. {participant.Key} <::> {participant.Value}");
                    placement++;
                }
            }

            int placementByTotalPoints = 1;
            Console.WriteLine("Individual standings:");

            foreach (var contest in contestByUsernameAndPoints)
            {
                foreach (var user in contest.Value)
                {
                    if (!usernameByTotalPoints.ContainsKey(user.Key))
                    {
                        usernameByTotalPoints.Add(user.Key, user.Value);
                    }
                    else
                    {
                        usernameByTotalPoints[user.Key] += user.Value;
                    }
                }
            }

            foreach (var participant in usernameByTotalPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{placementByTotalPoints}. {participant.Key} -> {participant.Value}");
                placementByTotalPoints++;
            }
        }
    }
}