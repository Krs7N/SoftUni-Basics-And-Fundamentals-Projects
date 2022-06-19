using System;

namespace _04.RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastNumberRange = int.Parse(Console.ReadLine());

            for (int startNumber = 2; startNumber <= lastNumberRange; startNumber++)
            {
                bool isNumberPrime = true;

                for (int division = 2; division < startNumber; division++)
                {
                    if (startNumber % division == 0)
                    {
                        isNumberPrime = false;
                        break;
                    }
                }

                Console.WriteLine("{0} -> {1}", startNumber, isNumberPrime.ToString().ToLower());
            }

        }
    }
}
