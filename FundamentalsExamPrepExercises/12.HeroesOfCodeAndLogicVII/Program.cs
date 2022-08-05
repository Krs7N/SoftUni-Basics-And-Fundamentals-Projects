using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.HeroesOfCodeAndLogicVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAXIMUM_HIT_POINTS = 100;
            const int MAXIMUM_MANA_POINTS = 200;

            List<Hero> heroes = new List<Hero>();

            int countOfHeroes = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfHeroes; i++)
            {
                string[] heroInformation = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string heroName = heroInformation[0];
                int hitPoints = int.Parse(heroInformation[1]);
                int manaPoints = int.Parse(heroInformation[2]);

                Hero hero = new Hero(heroName, hitPoints, manaPoints);
                heroes.Add(hero);
            }

            string[] commands = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "End")
            {
                string action = commands[0];

                switch (action)
                {
                    case "CastSpell":
                        CastSpell(commands[1], int.Parse(commands[2]), commands[3], heroes);
                        break;
                    case "TakeDamage":
                        TakeDamage(commands[1], int.Parse(commands[2]), commands[3], heroes);
                        break;
                    case "Recharge":
                        Recharge(commands[1], int.Parse(commands[2]), heroes, MAXIMUM_MANA_POINTS);
                        break;
                    case "Heal":
                        Heal(commands[1], int.Parse(commands[2]), heroes, MAXIMUM_HIT_POINTS);
                        break;
                }

                commands = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Name);
                Console.WriteLine($"  HP: {hero.HitPoints}");
                Console.WriteLine($"  MP: {hero.ManaPoints}");
            }
        }

        static void CastSpell(string heroName, int manaNeeded, string spellName, List<Hero> heroes)
        {
            Hero curHero = heroes.First(h => h.Name == heroName);

            if (curHero.ManaPoints >= manaNeeded)
            {
                curHero.ManaPoints -= manaNeeded;
                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {curHero.ManaPoints} MP!");
            }
            else
            {
                Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
            }
        }

        static void TakeDamage(string heroName, int damage, string attacker, List<Hero> heroes)
        {
            Hero curHero = heroes.First(h => h.Name == heroName);

            if (curHero.HitPoints - damage <= 0)
            {
                heroes.Remove(curHero);
                Console.WriteLine($"{heroName} has been killed by {attacker}!");
            }
            else
            {
                curHero.HitPoints -= damage;
                Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {curHero.HitPoints} HP left!");
            }
        }

        static void Recharge(string heroName, int amount, List<Hero> heroes, int maximumManaPoints)
        {
            Hero curHero = heroes.First(h => h.Name == heroName);

            int initialMana = curHero.ManaPoints;

            if (curHero.ManaPoints + amount > maximumManaPoints)
            {
                curHero.ManaPoints = maximumManaPoints;
            }
            else
            {
                curHero.ManaPoints += amount;
            }

            Console.WriteLine($"{heroName} recharged for {curHero.ManaPoints - initialMana} MP!");
        }

        static void Heal(string heroName, int amount, List<Hero> heroes, int maximumHitPoints)
        {
            Hero curHero = heroes.First(h => h.Name == heroName);

            int initialHealth = curHero.HitPoints;

            if (curHero.HitPoints + amount > maximumHitPoints)
            {
                curHero.HitPoints = maximumHitPoints;
            }
            else
            {
                curHero.HitPoints += amount;
            }

            Console.WriteLine($"{heroName} healed for {curHero.HitPoints - initialHealth} HP!");
        }
    }

    class Hero
    {
        public Hero(string heroName, int hitPoints, int manaPoints)
        {
            Name = heroName;
            HitPoints = hitPoints;
            ManaPoints = manaPoints;
        }

        public string Name { get; set; }

        public int HitPoints { get; set; }

        public int ManaPoints { get; set; }
    }
}