using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customerName>[A-Z][a-z]+)%[^.|$%]*<(?<product>\w+)>[^.|$%]*\|(?<count>\d+)\|[^.|$%]*?(?<price>\d+.?\d*)?\$";

            string input = Console.ReadLine();

            decimal totalSum = 0;

            while (input != "end of shift")
            {
                Match matches = Regex.Match(input, pattern);

                if (matches.Success)
                {
                    string customerName = matches.Groups["customerName"].Value;
                    string product = matches.Groups["product"].Value;
                    int count = int.Parse(matches.Groups["count"].Value);
                    decimal price = decimal.Parse(matches.Groups["price"].Value);

                    decimal totalPrice = price * count;

                    Console.WriteLine($"{customerName}: {product} - {totalPrice:f2}");

                    totalSum += totalPrice;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalSum:f2}");
        }
    }
}