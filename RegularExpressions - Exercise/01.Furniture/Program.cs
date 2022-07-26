using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<furniture>[A-Za-z\s]+)<<(?<price>\d+\.*?\d*)!(?<quantity>\d+)";
            string input = Console.ReadLine();

            decimal totalPrice = 0;

            List<string> validFurnitures = new List<string>();

            while (input != "Purchase")
            {
                Match matches = Regex.Match(input, pattern, RegexOptions.IgnoreCase);

                if (matches.Success)
                {
                    string name = matches.Groups["furniture"].Value;
                    decimal price = decimal.Parse(matches.Groups["price"].Value);
                    int quantity = int.Parse(matches.Groups["quantity"].Value);

                    validFurnitures.Add(name);
                    totalPrice += price * quantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            validFurnitures.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}