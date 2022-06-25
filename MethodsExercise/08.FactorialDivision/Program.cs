using System;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double resultFirstNum = FactorialFirstNum(firstNumber);
            double resultSecondNum = FactorialSecondNum(secondNumber);
            double finalResult = Division(resultFirstNum, resultSecondNum);

            Console.WriteLine($"{finalResult:f2}");
        }

        static double FactorialFirstNum(int firstNumber)
        {
            double result = 1;

            for (int i = firstNumber; i > 1; i--)
            {
                result *= i;
            }

            return result;
        }

        static double FactorialSecondNum(int secondNumber)
        {
            double result = 1;

            for (int i = secondNumber; i > 1; i--)
            {
                result *= i;
            }

            return result;
        }

        static double Division(double resultFirstNum, double resultSecondNum)
        { 
            double finalResult = resultFirstNum / resultSecondNum;

            return finalResult;
        }
    }
}
