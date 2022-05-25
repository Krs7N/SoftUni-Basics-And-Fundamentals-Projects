using System;

namespace E05.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string placeToStay = string.Empty;
            string vacation = string.Empty;
            if (budget <= 1000)
            {
                placeToStay = "Camp";
                switch (season)
                {
                    case "Summer":
                        budget *= 0.65m;
                        vacation = "Alaska";
                        break;
                    case "Winter":
                        budget *= 0.45m;
                        vacation = "Morocco";
                        break;
                }
            }
            else if (budget <= 3000)
            {
                placeToStay = "Hut";
                switch (season)
                {
                    case "Summer":
                        budget *= 0.8m;
                        vacation = "Alaska";
                        break;
                    case "Winter":
                        budget *= 0.6m;
                        vacation = "Morocco";
                        break;
                }
            }
            else
            {
                placeToStay = "Hotel";
                switch (season)
                {
                    case "Summer":
                        budget *= 0.9m;
                        vacation = "Alaska";
                        break;
                    case "Winter":
                        budget *= 0.9m;
                        vacation = "Morocco";
                        break;
                }
            }

            Console.WriteLine($"{vacation} - {placeToStay} - {budget:f2}");
        }
    }
}
