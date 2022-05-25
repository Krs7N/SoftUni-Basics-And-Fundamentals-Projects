using System;

namespace E06.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            //                                  Пролет / Есен   Лято        Зима
            //км на месец <= 5000               0.75 лв./км    0.90 лв./км  1.05 лв./км
            //5000 < км на месец <= 10000       0.95 лв./км    1.10 лв./км  1.25 лв./км
            //10000 < км на месец <= 20000      1.45 лв./км – за който и да е сезон
            string season = Console.ReadLine();
            decimal kilometres = decimal.Parse(Console.ReadLine());
            decimal salary = 0;
            if (kilometres <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        salary = kilometres * 0.75m;
                        break;
                    case "Summer":
                        salary = kilometres * 0.9m;
                        break;
                    case "Winter":
                        salary = kilometres * 1.05m;
                        break;
                }
            }
            else if (kilometres <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        salary = kilometres * 0.95m;
                        break;
                    case "Summer":
                        salary = kilometres * 1.1m;
                        break;
                    case "Winter":
                        salary = kilometres * 1.25m;
                        break;
                }
            }
            else if (kilometres <= 20000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                    case "Summer":
                    case "Winter":
                        salary = kilometres * 1.45m;
                        break;
                }
            }
            salary *= 4m;
            salary *= 0.9m;
            Console.WriteLine($"{salary:f2}");
        }
    }
}
