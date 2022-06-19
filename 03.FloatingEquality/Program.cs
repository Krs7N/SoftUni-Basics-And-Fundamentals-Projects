using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            double difference = Math.Abs(firstNumber - secondNumber);

            bool isNumberEqual = false;

            if (difference < eps)
            {
                isNumberEqual = true;
                Console.WriteLine(isNumberEqual);
            }
            else
            {
                Console.WriteLine(isNumberEqual);
            }
        }
    }
}
