using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DragonArmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDragons = int.Parse(Console.ReadLine());
            //            damage 45, health 250, armor 10 - default values
            // {type} {name} {damage} {health} {armor}

            var dragons = new List<Dragon>();

            for (int i = 0; i < numberOfDragons; i++)
            {
                string[] dragonInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string dragonType = dragonInfo[0];
                string dragonName = dragonInfo[1];
                string dragonDamage = dragonInfo[2];
                string dragonHealth = dragonInfo[3];
                string dragonArmor = dragonInfo[4];

                Dragon newDragon = new Dragon
                {
                    Type = dragonType,
                    Name = dragonName,
                    Damage = double.TryParse(dragonDamage, out var value) ? value : 45,
                    Health = double.TryParse(dragonHealth, out value) ? value : 250,
                    Armor = double.TryParse(dragonArmor, out value) ? value : 10,
                };

                Dragon existingDragon = dragons.SingleOrDefault(d => d.Name == dragonName && d.Type == dragonType);

                if (existingDragon != null)
                {
                    existingDragon.Damage = newDragon.Damage;
                    existingDragon.Health = newDragon.Health;
                    existingDragon.Armor = newDragon.Armor;
                }
                else dragons.Add(newDragon);

            }

            var sortedDragons = dragons.GroupBy(d => d.Type, d => d, (key, d) => new SortedDragon { Type = key, Dragons = d.ToList() });

            foreach (var dragon in sortedDragons)
            {
                int dragonCount = dragon.Dragons.Count;
                double damage = dragon.Dragons.Sum(d => d.Damage) / dragonCount;
                double health = dragon.Dragons.Sum(d => d.Health) / dragonCount;
                double armor = dragon.Dragons.Sum(d => d.Armor) / dragonCount;

                Console.WriteLine($"{dragon.Type}::({damage:f2}/{health:f2}/{armor:f2})");

                foreach (var sortedDragon in dragon.Dragons.OrderBy(d => d.Name))
                {
                    Console.WriteLine($"-{sortedDragon.Name} -> damage: {sortedDragon.Damage}, health: {sortedDragon.Health}, armor: {sortedDragon.Armor}");
                }
            }
        }
    }

    public class Dragon
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public double Damage { get; set; }

        public double Health { get; set; }

        public double Armor { get; set; }
    }

    public class SortedDragon
    {
        public string Type { get; set; }

        public List<Dragon> Dragons { get; set; }
    }
}
