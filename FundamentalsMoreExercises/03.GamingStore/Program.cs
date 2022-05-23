using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Name                      Price
            //  OutFall 4                   $39.99
            //  CS: OG                      $15.99
            //  Zplinter Zell               $19.99
            //  Honored 2                   $59.99
            //  RoverWatch                  $29.99
            //  RoverWatch Origins Edition  $39.99

            decimal balance = decimal.Parse(Console.ReadLine());
            string nameOfGame = Console.ReadLine();

            decimal totalSpent = 0;

            while (nameOfGame != "Game Time")
            {
                switch (nameOfGame)
                {
                    case "OutFall 4":
                        if (balance >= 39.99m)
                        {
                            balance -= 39.99m;
                            Console.WriteLine($"Bought {nameOfGame}");
                            totalSpent += 39.99m;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (balance >= 15.99m)
                        {
                            balance -= 15.99m;
                            Console.WriteLine($"Bought {nameOfGame}");
                            totalSpent += 15.99m;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (balance >= 19.99m)
                        {
                            balance -= 19.99m;
                            Console.WriteLine($"Bought {nameOfGame}");
                            totalSpent += 19.99m;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (balance >= 59.99m)
                        {
                            balance -= 59.99m;
                            Console.WriteLine($"Bought {nameOfGame}");
                            totalSpent += 59.99m;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (balance >= 29.99m)
                        {
                            balance -= 29.99m;
                            Console.WriteLine($"Bought {nameOfGame}");
                            totalSpent += 29.99m;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (balance >= 39.99m)
                        {
                            balance -= 39.99m;
                            Console.WriteLine($"Bought {nameOfGame}");
                            totalSpent += 39.99m;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                nameOfGame = Console.ReadLine();
            }

            Console.Write($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");
        }
    }
}
