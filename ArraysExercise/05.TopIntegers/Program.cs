using System;
using System.Linq;

namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                bool currNumIsBigger = true;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        currNumIsBigger = false;
                        break;
                    }
                }

                if (currNumIsBigger)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
