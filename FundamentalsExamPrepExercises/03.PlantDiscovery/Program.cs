using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPlants = int.Parse(Console.ReadLine());

            var plantNamesByRarity = new Dictionary<string, int>();
            var plantRatings = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfPlants; i++)
            {
                string[] plantInfo = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plantName = plantInfo[0];
                int rarity = int.Parse(plantInfo[1]);

                if (!plantNamesByRarity.ContainsKey(plantName))
                {
                    plantNamesByRarity.Add(plantName, rarity);
                }
                else
                {
                    plantNamesByRarity.Remove(plantName);
                    plantNamesByRarity.Add(plantName, rarity);
                }
            }

            string[] commands = Console.ReadLine().Split(new[] { ':', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "Exhibition")
            {
                string action = commands[0].Trim();
                string plant = commands[1].Trim();

                if (!plantNamesByRarity.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                }
                else
                {
                    switch (action)
                    {
                        case "Rate":
                            Rate(plant, int.Parse(commands[2]), plantNamesByRarity, plantRatings);
                            break;
                        case "Update":
                            Update(plant, int.Parse(commands[2]), plantNamesByRarity);
                            break;
                        case "Reset":
                            Reset(plant, plantNamesByRarity, plantRatings);
                            break;
                    }
                }

                commands = Console.ReadLine().Split(new[] { ':', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plantNamesByRarity)
            {
                foreach (var rating in plantRatings)
                {
                    if (plant.Key == rating.Key)
                    {
                        if (rating.Value.Count == 0)
                        {
                            Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value}; Rating: 0.00");
                            break;
                        }
                        
                        Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value}; Rating: {rating.Value.Average():f2}");
                        break;
                    }
                }
            }
        }

        static void Rate(string plant, int rating, Dictionary<string, int> plantNamesByRarity, Dictionary<string, List<double>> plantRatings)
        {
            if (plantRatings.ContainsKey(plant))
            {
                plantRatings[plant].Add(rating);
            }
            else
            {
                plantRatings[plant] = new List<double> { rating };
            }
        }

        static void Update(string plant, int newRarity, Dictionary<string, int> plantNamesByRarity)
        {
            plantNamesByRarity[plant] = newRarity;
        }

        static void Reset(string plant, Dictionary<string, int> plantNamesByRarity, Dictionary<string, List<double>> plantRatings)
        {
            plantRatings[plant].Clear();
        }
    }
}