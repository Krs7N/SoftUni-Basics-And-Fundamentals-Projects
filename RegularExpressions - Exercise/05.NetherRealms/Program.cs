using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patternForHealth = @"[^\+\-\*\/\.,0-9]";
            string damagePattern = @"-?\d+\.?\d*";
            string multiplyDividePattern = @"[\*\/]";
            string splitPattern = @"[,\s]+";

            string input = Console.ReadLine();
            List<string> demons = Regex.Split(input, splitPattern).OrderBy(x => x).ToList();

            foreach (var demon in demons)
            {
                string curDemon = demon;
                MatchCollection healthMatched = Regex.Matches(demon, patternForHealth);

                int health = 0;

                foreach (Match healthMatch in healthMatched)
                {
                    char curChar = char.Parse(healthMatch.ToString());
                    health += curChar;
                }

                MatchCollection damageMatched = Regex.Matches(demon, damagePattern);

                double damage = 0;

                foreach (Match damageMatch in damageMatched)
                {
                    double curNumber = double.Parse(damageMatch.ToString());
                    damage += curNumber;
                }

                MatchCollection multipliersOrDividers = Regex.Matches(demon, multiplyDividePattern);

                foreach (Match multiplierOrDivider in multipliersOrDividers)
                {
                    char curOperator = char.Parse(multiplierOrDivider.ToString());
                    if (curOperator == '*') damage *= 2;
                    else if (curOperator == '/') damage /= 2;
                }

                Console.WriteLine($"{curDemon} - {health} health, {damage:f2} damage");
            }
        }
    }
}
