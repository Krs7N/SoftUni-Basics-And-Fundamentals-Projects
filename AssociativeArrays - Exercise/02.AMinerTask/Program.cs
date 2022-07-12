using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourcesByQuantity = new Dictionary<string, int>();

            string resource = Console.ReadLine();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resourcesByQuantity.ContainsKey(resource))
                {
                    resourcesByQuantity.Add(resource, quantity);
                }
                else
                {
                    resourcesByQuantity[resource] += quantity;
                }

                resource = Console.ReadLine();
            }

            foreach (var resourceByQuantity in resourcesByQuantity)
            {
                Console.WriteLine($"{resourceByQuantity.Key} -> {resourceByQuantity.Value}");
            }
        }
    }
}
