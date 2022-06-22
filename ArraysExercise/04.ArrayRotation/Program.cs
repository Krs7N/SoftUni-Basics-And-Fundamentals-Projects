using System;
using System.Linq;

namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int element = originalArray[0];

                for (int rotation = 0; rotation < originalArray.Length - 1; rotation++)
                {
                    originalArray[rotation] = originalArray[rotation + 1];
                }

                originalArray[originalArray.Length - 1] = element;
            }

            Console.WriteLine(string.Join(' ', originalArray));
        }
    }
}
