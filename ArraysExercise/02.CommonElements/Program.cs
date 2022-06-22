using System;
using System.Linq;

namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] secondArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var element in secondArray)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (firstArray[j] == element)
                    {
                        Console.Write(element + ' ');
                    }
                }
            }

            //for (int i = 0; i < secondArray.Length; i++)
            //{
            //    for (int j = 0; j < firstArray.Length; j++)
            //    {
            //        if (firstArray[j] == secondArray[i])
            //        {
            //            Console.Write(secondArray[i] + ' ');
            //        }
            //    }
            //}
        }
    }
}
