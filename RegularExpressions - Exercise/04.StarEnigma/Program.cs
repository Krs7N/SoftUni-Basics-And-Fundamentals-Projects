using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace _04.StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@(?<planetName>[A-Za-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<type>[A|D])![^@\-!:>]*->(?<soldierCount>\d+)";

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            int linesOfInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesOfInput; i++)
            {
                string encryptedMessage = Console.ReadLine();
                int sum = encryptedMessage.ToLower().Count(x => x == 's' || x == 't' || x == 'a' || x == 'r');
                StringBuilder decryptedMessage = new StringBuilder();

                foreach (var currentChar in encryptedMessage)
                {
                    decryptedMessage.Append((char)(currentChar - sum));
                }

                Match match = Regex.Match(decryptedMessage.ToString(), pattern, RegexOptions.IgnoreCase);

                if (match.Success)
                {
                    string planetName = match.Groups["planetName"].Value;
                    int population = int.Parse(match.Groups["population"].Value);
                    char typeOfAttack = char.Parse(match.Groups["type"].Value);
                    int soldierCount = int.Parse(match.Groups["soldierCount"].Value);

                    if (typeOfAttack == 'A') attackedPlanets.Add(planetName);
                    else destroyedPlanets.Add(planetName);
                }
            }

            //attackedPlanets.Sort();
            //destroyedPlanets.Sort();

            //Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            //foreach (var attackedPlanet in attackedPlanets)
            //{
            //    Console.WriteLine($"-> {attackedPlanet}");
            //}
            //Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            //foreach (var destroyedPlanet in destroyedPlanets)
            //{
            //    Console.WriteLine($"-> {destroyedPlanet}");
            //}

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            attackedPlanets.OrderBy(x => x).ToList().ForEach(attackedPlanet => Console.WriteLine($"-> {attackedPlanet}"));
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            destroyedPlanets.OrderBy(x => x).ToList().ForEach(destroyedPlanet => Console.WriteLine($"-> {destroyedPlanet}"));
        }
    }
}
