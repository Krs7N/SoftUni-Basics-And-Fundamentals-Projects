using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] teamInformation = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);

                string creator = teamInformation[0];
                string teamName = teamInformation[1];

                if (teams.Any(team => team.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(team => team.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team();
                    team.Name = teamName;
                    team.Creator = creator;
                    team.Members = new List<string>();
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string command = Console.ReadLine();

            while (command != "end of assignment")
            {
                string[] membersInfo = command.Split("->", StringSplitOptions.RemoveEmptyEntries);

                string memberName = membersInfo[0];
                string teamToJoin = membersInfo[1];

                if (teams.All(team => team.Name != teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else if (teams.Any(team => team.Members.Contains(memberName)) || teams.Any(creator => creator.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamToJoin}!");
                }
                else
                {
                    Team curTeam = teams.Find(team => team.Name == teamToJoin);
                    curTeam.Members.Add(memberName);
                }

                command = Console.ReadLine();
            }

            List<Team> completedTeams = teams.Where(team => team.Members.Count > 0).ToList();
            List<Team> disbandedTeams = teams.Where(team => team.Members.Count == 0).ToList();

            foreach (Team team in completedTeams.OrderByDescending(team => team.Members.Count).ThenBy(team => team.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (string member in team.Members.OrderBy(member => member))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            if (disbandedTeams != null)
            {
                foreach (Team disbandedTeam in disbandedTeams.OrderBy(team => team.Name))
                {
                    Console.WriteLine(disbandedTeam.Name);
                }
            }
        }
    }

    class Team
    {
        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }
}