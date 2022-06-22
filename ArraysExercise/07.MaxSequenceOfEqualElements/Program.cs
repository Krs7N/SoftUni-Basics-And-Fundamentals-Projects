using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int counter = 0;
            int mostEqualElements = 0;
            string element = string.Empty;

            for (int leftNum = 0; leftNum < arr.Length - 1; leftNum++)
            {
                if (arr[leftNum] == arr[leftNum + 1])
                {
                    counter++;
                    if (counter > mostEqualElements)
                    {
                        mostEqualElements = counter;
                        element = arr[leftNum].ToString();
                    }
                }
                else
                {
                    counter = 0;
                }
            }

            for (int j = 0; j <= mostEqualElements; j++)
            {
                Console.Write(element + ' ');
            }
        }
    }
}
