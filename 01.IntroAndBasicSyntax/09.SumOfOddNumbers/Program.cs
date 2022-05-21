using System;

namespace _09.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int cnt = 1; cnt <= numbers; cnt++)
            {
                int oddNum = (cnt * 2) - 1;

                Console.WriteLine(oddNum);
                sum += oddNum;

            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
