using System;

namespace _01.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            if (firstNum > secondNum && firstNum > thirdNum)
            {
                Console.WriteLine(firstNum);
                if (secondNum > thirdNum)
                {
                    Console.WriteLine(secondNum);
                    Console.WriteLine(thirdNum);
                }
                else
                {
                    Console.WriteLine(thirdNum);
                    Console.WriteLine(secondNum);
                }
            }
            else if (secondNum > firstNum && secondNum > thirdNum)
            {
                Console.WriteLine(secondNum);
                if (firstNum > thirdNum)
                {
                    Console.WriteLine(firstNum);
                    Console.WriteLine(thirdNum);
                }
                else
                {
                    Console.WriteLine(thirdNum);
                    Console.WriteLine(firstNum);
                }
            }
            else if (thirdNum > firstNum && thirdNum > secondNum)
            {
                Console.WriteLine(thirdNum);
                if (firstNum > secondNum)
                {
                    Console.WriteLine(firstNum);
                    Console.WriteLine(secondNum);
                }
                else
                {
                    Console.WriteLine(secondNum);
                    Console.WriteLine(firstNum);
                }
            }
        }
    }
}
