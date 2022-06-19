using System;

namespace _06.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int openingBracketCnt = 0;
            int closingBracketCnt = 0;

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    openingBracketCnt++;
                }
                else if (input == ")")
                {
                    closingBracketCnt++;
                }
                if (closingBracketCnt > openingBracketCnt)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }

            if (openingBracketCnt == closingBracketCnt)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
