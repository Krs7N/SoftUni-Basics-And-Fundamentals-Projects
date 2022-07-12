using System;
using System.Collections.Generic;

namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> orders = new Dictionary<string, double>();
            Dictionary<string, int> newOrders = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] cmd = input.Split();
                string productName = cmd[0];
                double productPrice = double.Parse(cmd[1]);
                int productQuantity = int.Parse(cmd[2]);

                if (!orders.ContainsKey(productName))
                {
                    orders[productName] = productPrice;
                    newOrders[productName] = productQuantity;
                }
                else if (orders.ContainsKey(productName))
                {
                    orders.Remove(productName);
                    orders[productName] = productPrice;
                    newOrders[productName] += productQuantity;
                }

                input = Console.ReadLine();
            }

            foreach (var order in orders)
            {
                foreach (var newOrder in newOrders)
                {
                    if (order.Key == newOrder.Key)
                    {
                        Console.WriteLine($"{order.Key} -> {order.Value * newOrder.Value:f2}");
                    }
                }
            }
        }
    }
}
