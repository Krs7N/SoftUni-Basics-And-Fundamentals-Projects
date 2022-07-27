using System;

namespace _12.EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = int.Parse(Console.ReadLine());
            //while (num % 2 != 0)
            //{
            //    Console.WriteLine("Please write an even number.");
            //    num = int.Parse(Console.ReadLine());
            //}

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine($"The number is: {Math.Abs(num)}");
            //    return;
            //}

            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    return;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}
