using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (firstDeck.Count > 0 && secondDeck.Count > 0)
            {
                if (firstDeck[0] > secondDeck[0])
                {
                    firstDeck.Add(firstDeck[0]);
                    firstDeck.Add(secondDeck[0]);
                }
                else if (firstDeck[0] < secondDeck[0])
                {
                    secondDeck.Add(secondDeck[0]);
                    secondDeck.Add(firstDeck[0]);
                }

                firstDeck.Remove(firstDeck[0]);
                secondDeck.Remove(secondDeck[0]);

                if (firstDeck.Count == 0)
                {
                    int sum = secondDeck.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }

                if (secondDeck.Count == 0)
                {
                    int sum = firstDeck.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}
