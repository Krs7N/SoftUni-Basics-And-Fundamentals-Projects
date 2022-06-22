using System;
using System.Linq;

namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int desiredSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int nextNum = i + 1; nextNum < arr.Length; nextNum++)
                {
                    if (arr[i] + arr[nextNum] == desiredSum)
                    {
                        Console.WriteLine($"{arr[i]} {arr[nextNum]}");
                        break;
                    }
                }
            }
        }
    }
}
