using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CONSUMED_BY_WORKERS = 26;
            const int MINIMUM_SPICES_TO_GATHER = 100;
            const int DAILY_DECREASE_OF_MINE_YIELD = 10;

            int countSpices = int.Parse(Console.ReadLine());
            int totalConsumed = 0;
            int daysCnt = 0;

            while (countSpices >= MINIMUM_SPICES_TO_GATHER)
            {
                totalConsumed += countSpices - CONSUMED_BY_WORKERS;
                countSpices -= DAILY_DECREASE_OF_MINE_YIELD;
                daysCnt++;
                if (countSpices < MINIMUM_SPICES_TO_GATHER)
                {
                    totalConsumed -= CONSUMED_BY_WORKERS;
                }
            }

            Console.WriteLine(daysCnt);
            Console.WriteLine(totalConsumed);
        }
    }
}
