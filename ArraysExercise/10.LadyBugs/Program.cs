using System;
using System.Linq;

namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugsField = new int[fieldSize];

            string[] occupiedIndices = Console.ReadLine().Split();

            for (int i = 0; i < occupiedIndices.Length; i++)
            {
                int currentIndex = int.Parse(occupiedIndices[i]);
                if (currentIndex >= 0 && currentIndex < fieldSize)
                {
                    ladyBugsField[currentIndex] = 1;
                }
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                bool isFirst = true;
                int currentIndex = int.Parse(command[0]);
                while (currentIndex >= 0 && currentIndex < fieldSize && ladyBugsField[currentIndex] != 0)
                {
                    if (isFirst)
                    {
                        ladyBugsField[currentIndex] = 0;
                        isFirst = false;
                    }

                    string direction = command[1];
                    int indicesToMove = int.Parse(command[2]);

                    if (direction == "left")
                    {
                        currentIndex -= indicesToMove;
                        if (currentIndex >= 0 && currentIndex < fieldSize)
                        {
                            if (ladyBugsField[currentIndex] == 0)
                            {
                                ladyBugsField[currentIndex] = 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        currentIndex += indicesToMove;
                        if (currentIndex >= 0 && currentIndex < fieldSize)
                        {
                            if (ladyBugsField[currentIndex] == 0)
                            {
                                ladyBugsField[currentIndex] = 1;
                                break;
                            }
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(' ', ladyBugsField));
        }
    }
}
