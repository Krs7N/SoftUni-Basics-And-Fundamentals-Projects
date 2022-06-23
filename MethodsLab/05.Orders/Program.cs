using System;

namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantityForProduct = int.Parse(Console.ReadLine());

            CalculatePrice(product, quantityForProduct);
        }

        static void CalculatePrice(string product, int quantityForProduct)
        {
            switch (product)
            {
                case "coffee":
                    PriceCoffee(quantityForProduct);
                    break;
                case "water":
                    PriceWater(quantityForProduct);
                    break;
                case "coke":
                    PriceCoke(quantityForProduct);
                    break;
                case "snacks":
                    PriceSnacks(quantityForProduct);
                    break;
            }
        }

        static void PriceCoffee(int quantityForProduct)
        {
            double price = 1.5;
            Console.WriteLine($"{quantityForProduct * price:f2}");
        }

        static void PriceWater(int quantityForProduct)
        {
            double price = 1;
            Console.WriteLine($"{quantityForProduct * price:f2}");
        }

        static void PriceCoke(int quantityForProduct)
        {
            double price = 1.4;
            Console.WriteLine($"{quantityForProduct * price:f2}");
        }

        static void PriceSnacks(int quantityForProduct)
        {
            double price = 2;
            Console.WriteLine($"{quantityForProduct * price:f2}");
        }
    }
}
