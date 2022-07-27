using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string productOrCoins = Console.ReadLine();
            double coinsAccumulated = 0;

            while (productOrCoins != "Start")
            {
                double coins = double.Parse(productOrCoins);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    coinsAccumulated += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                productOrCoins = Console.ReadLine();
            }

            productOrCoins = Console.ReadLine();

            while (productOrCoins != "End")
            {
                switch (productOrCoins)
                {
                    case "Nuts":
                        if (coinsAccumulated >= 2)
                        {
                            coinsAccumulated -= 2;
                            Console.WriteLine($"Purchased {productOrCoins.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (coinsAccumulated >= 0.7)
                        {
                            coinsAccumulated -= 0.7;
                            Console.WriteLine($"Purchased {productOrCoins.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (coinsAccumulated >= 1.5)
                        {
                            coinsAccumulated -= 1.5;
                            Console.WriteLine($"Purchased {productOrCoins.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (coinsAccumulated >= 0.8)
                        {
                            coinsAccumulated -= 0.8;
                            Console.WriteLine($"Purchased {productOrCoins.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (coinsAccumulated >= 1)
                        {
                            coinsAccumulated -= 1;
                            Console.WriteLine($"Purchased {productOrCoins.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        productOrCoins = Console.ReadLine();
                        continue;
                }
                productOrCoins = Console.ReadLine();
            }

            Console.WriteLine($"Change: {coinsAccumulated:f2}");
        }
    }
}
