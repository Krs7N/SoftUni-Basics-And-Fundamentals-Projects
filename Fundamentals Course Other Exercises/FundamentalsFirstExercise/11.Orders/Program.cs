using System;

namespace _11.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntOfOrders = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            for (int i = 1; i <= cntOfOrders; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int daysMonth = int.Parse(Console.ReadLine());
                int capsulesCnt = int.Parse(Console.ReadLine());

                double price = ((daysMonth * capsulesCnt) * capsulePrice);
                totalPrice += price;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");

                if (i == cntOfOrders)
                {
                    Console.WriteLine($"Total: ${totalPrice:f2}");
                }
            }
        
        }
    }
}
