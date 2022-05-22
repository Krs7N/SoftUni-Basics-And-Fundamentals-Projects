using System;

namespace _08.TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberForTriangle = int.Parse(Console.ReadLine());

            for (int column = 1; column <= numberForTriangle; column++)
            {
                for (int row = 1; row <= column; row++)
                {
                    Console.Write(column + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
