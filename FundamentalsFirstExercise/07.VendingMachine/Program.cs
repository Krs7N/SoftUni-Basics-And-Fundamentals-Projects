using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double coinsAccumulated = 0;

            while (command != "Start")
            {
                double coins = double.Parse(command);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2 || coins == 5)
                {
                    coinsAccumulated += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                switch (command)
                {
                    case "Nuts":
                        if (coinsAccumulated >= 2)
                        {
                            coinsAccumulated -= 2;
                            Console.WriteLine($"Purchased {command.ToLower()}");
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
                            Console.WriteLine($"Purchased {command.ToLower()}");
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
                            Console.WriteLine($"Purchased {command.ToLower()}");
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
                            Console.WriteLine($"Purchased {command.ToLower()}");
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
                            Console.WriteLine($"Purchased {command.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Pie":
                        if (coinsAccumulated >= 5)
                        {
                            coinsAccumulated -= 5;
                            Console.WriteLine($"Purchased {command.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Pizza":
                        if (coinsAccumulated >= 2.5)
                        {
                            coinsAccumulated -= 2.5;
                            Console.WriteLine($"Purchased {command.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        command = Console.ReadLine();
                        continue;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Change: {coinsAccumulated:f2}");
        }
    }
}
