using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();

            decimal totalSum = 0;

            switch (day)
            {
                case "Friday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            totalSum = people * 8.45m;
                            if (people >= 30) totalSum *= 0.85m;
                            break;
                        case "Business":
                            totalSum = people * 10.9m;
                            if (people >= 100) totalSum -= totalSum / people * 10;
                            break;
                        case "Regular":
                            totalSum = people * 15m;
                            if (people >= 10 && people <= 20) totalSum *= 0.95m;
                            break;
                    }
                    break;
                case "Saturday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            totalSum = people * 9.8m;
                            if (people >= 30) totalSum *= 0.85m;
                            break;
                        case "Business":
                            totalSum = people * 15.6m;
                            if (people >= 100) totalSum -= totalSum / people * 10;
                            break;
                        case "Regular":
                            totalSum = people * 20m;
                            if (people >= 10 && people <= 20) totalSum *= 0.95m;
                            break;
                    }
                    break;
                case "Sunday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            totalSum = people * 10.46m;
                            if (people >= 30) totalSum *= 0.85m;
                            break;
                        case "Business":
                            totalSum = people * 16m;
                            if (people >= 100) totalSum -= totalSum / people * 10;
                            break;
                        case "Regular":
                            totalSum = people * 22.5m;
                            if (people >= 10 && people <= 20) totalSum *= 0.95m;
                            break;
                    }
                    break;
            }

            Console.WriteLine($"Total price: {totalSum:f2}");
        }
    }
}
