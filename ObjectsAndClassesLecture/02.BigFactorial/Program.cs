using System;
using System.Numerics;

namespace _02.BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 2; i <= endNumber; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
