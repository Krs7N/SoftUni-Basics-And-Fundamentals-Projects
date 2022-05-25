using System;

namespace E07.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeOfGroup = Console.ReadLine();
            int studentsCnt = int.Parse(Console.ReadLine());
            int nightsCnt = int.Parse(Console.ReadLine());
            decimal price = 0;
            string sport = string.Empty;
            switch (typeOfGroup)
            {
                case "boys":
                case "girls":
                    switch (season)
                    {
                        case "Winter":
                            price = studentsCnt * nightsCnt * 9.6m;
                            break;
                        case "Spring":
                            price = studentsCnt * nightsCnt * 7.2m;
                            break;
                        case "Summer":
                            price = studentsCnt * nightsCnt * 15m;
                            break;
                    }
                    break;
                case "mixed":
                    switch (season)
                    {
                        case "Winter":
                            price = studentsCnt * nightsCnt * 10m;
                            break;
                        case "Spring":
                            price = studentsCnt * nightsCnt * 9.5m;
                            break;
                        case "Summer":
                            price = studentsCnt * nightsCnt * 20m;
                            break;
                    }
                    break;
            }

            if (studentsCnt >= 50)
            {
                price *= 0.5m;
            }
            else if (studentsCnt >= 20 && studentsCnt < 50)
            {
                price *= 0.85m;
            }
            else if (studentsCnt >= 10 && studentsCnt < 20)
            {
                price *= 0.95m;
            }

            switch (season)
            {
                case "Winter":
                    switch (typeOfGroup)
                    {
                        case "girls":
                            sport = "Gymnastics";
                            break;
                        case "boys":
                            sport = "Judo";
                            break;
                        case "mixed":
                            sport = "Ski";
                            break;
                    }
                    break;
                case "Spring":
                    switch (typeOfGroup)
                    {
                        case "girls":
                            sport = "Athletics";
                            break;
                        case "boys":
                            sport = "Tennis";
                            break;
                        case "mixed":
                            sport = "Cycling";
                            break;
                    }
                    break;
                case "Summer":
                    switch (typeOfGroup)
                    {
                        case "girls":
                            sport = "Volleyball";
                            break;
                        case "boys":
                            sport = "Football";
                            break;
                        case "mixed":
                            sport = "Swimming";
                            break;
                    }
                    break;
            }

            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}