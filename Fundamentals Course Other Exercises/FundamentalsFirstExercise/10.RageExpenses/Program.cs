using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesLost = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            int keyboardTrashCnt = 0;

            decimal totalRageExpenses = 0;

            for (int gamesLostCnt = 1; gamesLostCnt <= gamesLost; gamesLostCnt++)
            {
                if (gamesLostCnt % 2 == 0)
                {
                    totalRageExpenses += headsetPrice;
                }

                if (gamesLostCnt % 3 == 0)
                {
                    totalRageExpenses += mousePrice;
                }

                if (gamesLostCnt % 2 == 0 && gamesLostCnt % 3 == 0)
                {
                    totalRageExpenses += keyboardPrice;
                    keyboardTrashCnt++;
                }

                if (keyboardTrashCnt == 2)
                {
                    keyboardTrashCnt = 0;
                    totalRageExpenses += displayPrice;
                }
            }

            Console.WriteLine($"Rage expenses: {totalRageExpenses:f2} lv.");
        }
    }
}
