using System;
using System.Collections.Generic;

namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> carsByUsers = new Dictionary<string, string>();

            int numberOfCmds = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCmds; i++)
            {
                string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (commands[0])
                {
                    case "register":
                        string username = commands[1];
                        string licensePlate = commands[2];
                        if (!carsByUsers.ContainsKey(username))
                        {
                            carsByUsers[username] = licensePlate;
                            Console.WriteLine($"{username} registered {licensePlate} successfully");
                        }
                        else Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        break;
                    case "unregister":
                        username = commands[1];
                        if (!carsByUsers.ContainsKey(username)) Console.WriteLine($"ERROR: user {username} not found");
                        else
                        {
                            carsByUsers.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        break;
                }
            }

            foreach (var carByUser in carsByUsers)
            {
                Console.WriteLine($"{carByUser.Key} => {carByUser.Value}");
            }
        }
    }
}
