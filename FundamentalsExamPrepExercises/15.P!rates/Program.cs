using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cityByPopulationAndGold = new Dictionary<string, Pirate>();

            string[] tokens = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0] != "Sail")
            {
                string cityName = tokens[0];
                int population = int.Parse(tokens[1]);
                int gold = int.Parse(tokens[2]);


                if (!cityByPopulationAndGold.ContainsKey(cityName))
                {
                    cityByPopulationAndGold.Add(cityName, new Pirate(population, gold));
                }
                else
                {
                    cityByPopulationAndGold[cityName].Population += population;
                    cityByPopulationAndGold[cityName].Gold += gold;
                }

                tokens = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries);
            }

            string[] commands = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "End")
            {
                string action = commands[0];

                switch (action)
                {
                    case "Plunder":
                        Plunder(commands[1], int.Parse(commands[2]), int.Parse(commands[3]), cityByPopulationAndGold);
                        break;
                    case "Prosper":
                        Prosper(commands[1], int.Parse(commands[2]), cityByPopulationAndGold);
                        break;
                }

                commands = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            }

            if (cityByPopulationAndGold.Count <= 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cityByPopulationAndGold.Count} wealthy settlements to go to:");
                foreach (var city in cityByPopulationAndGold)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
                }
            }
        }

        static void Plunder(string town, int people, int gold, Dictionary<string, Pirate> cityByPopulationAndGold)
        {
            var curCity = cityByPopulationAndGold.First(c => c.Key == town);

            curCity.Value.Gold -= gold;
            curCity.Value.Population -= people;

            Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

            if (curCity.Value.Gold <= 0 || curCity.Value.Population <= 0)
            {
                cityByPopulationAndGold.Remove(town);
                Console.WriteLine($"{town} has been wiped off the map!");
            }
        }

        static void Prosper(string town, int gold, Dictionary<string, Pirate> cityByPopulationAndGold)
        {
            var curCity = cityByPopulationAndGold.First(c => c.Key == town);

            if (gold < 0)
            {
                Console.WriteLine("Gold added cannot be a negative number!");

                return;
            }

            curCity.Value.Gold += gold;
            Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {curCity.Value.Gold} gold.");
        }
    }

    class Pirate
    {
        public Pirate(int population, int gold)
        {
            Population = population;
            Gold = gold;
        }

        public int Population { get; set; }

        public int Gold { get; set; }
    }
}