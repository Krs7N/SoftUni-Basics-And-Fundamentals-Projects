using System;

namespace _01.IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int divideNum = int.Parse(Console.ReadLine());
            int multiplyNum = int.Parse(Console.ReadLine());

            int sumNums = firstNum + secondNum;
            int divisionResult = sumNums / divideNum;
            int multiplyResult = divisionResult * multiplyNum;

            Console.WriteLine(multiplyResult);
        }
    }
}
