using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            BigInteger bestSnowball = int.MinValue;

            string bestSnowballFormula = string.Empty;

            for (int i = 0; i < snowballs; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());

                BigInteger currentSnowballValue = snowballSnow / snowballTime;
                snowballValue = BigInteger.Pow(currentSnowballValue, snowballQuality);
                if (snowballValue > bestSnowball)
                {
                    bestSnowball = snowballValue;
                    bestSnowballFormula = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
                }
            }

            Console.WriteLine(bestSnowballFormula);
        }
    }
}
