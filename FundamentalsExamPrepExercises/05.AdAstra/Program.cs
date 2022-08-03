using System;
using System.Text.RegularExpressions;

namespace _05.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([\||#])(?<food>[A-Za-z ]+)\1(?<expiration>[0-3][0-9]/\d{2}/\d{2})\1(?<calories>\d+)\1";
            // 2000kcal a day needed
            string textWithIngredients = Console.ReadLine();

            MatchCollection matches = Regex.Matches(textWithIngredients, pattern);

            int totalCalories = 0;
            string foodName = string.Empty;
            string expiration = string.Empty;
            int calories;

            foreach (Match match in matches)
            {
                calories = int.Parse(match.Groups["calories"].Value);

                totalCalories += calories;
            }

            int days = totalCalories / 2000;
            
            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match match in matches)
            {
                foodName = match.Groups["food"].Value;
                expiration = match.Groups["expiration"].Value;
                calories = int.Parse(match.Groups["calories"].Value);

                Console.WriteLine($"Item: {foodName}, Best before: {expiration}, Nutrition: {calories}");
            }
        }
    }
}
