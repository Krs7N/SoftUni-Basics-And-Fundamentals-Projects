using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CAPACITY = 255;
            int nLines = int.Parse(Console.ReadLine());
            int totalQuantity = CAPACITY;

            for (int i = 0; i < nLines; i++)
            {
                int currQuantity = int.Parse(Console.ReadLine());
                if (totalQuantity - currQuantity >= 0)
                {
                    totalQuantity -= currQuantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            int totalUsedQuantity = CAPACITY - totalQuantity;
            Console.WriteLine(totalUsedQuantity);
        }
    }
}
