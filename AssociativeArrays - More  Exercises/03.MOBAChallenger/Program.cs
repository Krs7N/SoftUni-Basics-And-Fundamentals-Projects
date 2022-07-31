using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MOBAChallenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var playersByPositionsAndSkills = new Dictionary<string, Dictionary<string, int>>();

            string player = string.Empty;
            string position = string.Empty;
            int skill;

            string information = Console.ReadLine();

            while (information != "Season end")
            {
                if (!information.Contains(" vs "))
                {
                    string[] playerInfo = information.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    player = playerInfo[0];
                    position = playerInfo[1];
                    skill = int.Parse(playerInfo[2]);

                    if (!playersByPositionsAndSkills.ContainsKey(player))
                    {
                        playersByPositionsAndSkills.Add(player, new Dictionary<string, int>());
                        playersByPositionsAndSkills[player].Add(position, skill);
                    }
                    else
                    {
                        if (!playersByPositionsAndSkills[player].ContainsKey(position))
                        {
                            playersByPositionsAndSkills[player].Add(position, skill);

                        }
                        else
                        {
                            if (playersByPositionsAndSkills[player][position] < skill)
                            {
                                playersByPositionsAndSkills[player][position] = skill;
                            }
                        }
                    }
                }
                else
                {
                    string[] battleInfo = information.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
                    string firstPlayer = battleInfo[0];
                    string secondPlayer = battleInfo[1];

                    if (playersByPositionsAndSkills.ContainsKey(firstPlayer) &&
                        playersByPositionsAndSkills.ContainsKey(secondPlayer))
                    {
                        string removePlayer = string.Empty;

                        foreach (var pos in playersByPositionsAndSkills[firstPlayer])
                        {
                            foreach (var posSecondPlayer in playersByPositionsAndSkills[secondPlayer])
                            {
                                if (pos.Key == posSecondPlayer.Key)
                                {
                                    if (playersByPositionsAndSkills[firstPlayer].Values.Sum() > playersByPositionsAndSkills[secondPlayer].Values.Sum())
                                    {
                                        removePlayer = secondPlayer;
                                    }
                                    else if (playersByPositionsAndSkills[firstPlayer].Values.Sum() < playersByPositionsAndSkills[secondPlayer].Values.Sum())
                                    {
                                        removePlayer = firstPlayer;
                                    }
                                }
                            }
                        }

                        playersByPositionsAndSkills.Remove(removePlayer);
                    }
                }

                information = Console.ReadLine();
            }

            foreach (var players in playersByPositionsAndSkills.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{players.Key}: {players.Value.Values.Sum()} skill");

                foreach (var positionAndSkills in players.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {positionAndSkills.Key} <::> {positionAndSkills.Value}");
                }
            }
        }
    }
}