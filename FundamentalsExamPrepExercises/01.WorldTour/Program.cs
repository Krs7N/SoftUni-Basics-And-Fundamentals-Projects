using System;

namespace _01.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destinations = Console.ReadLine();
            string[] command = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Travel")
            {
                string action = command[0];

                switch (action)
                {
                    case "Add Stop":
                        destinations = AddStop(int.Parse(command[1]), command[2], destinations);
                        break;
                    case "Remove Stop":
                        destinations = RemoveStop(int.Parse(command[1]), int.Parse(command[2]), destinations);
                        break;
                    case "Switch":
                        destinations = Switch(command[1], command[2], destinations);
                        break;
                }

                command = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");
        }

        static string AddStop(int index, string newStop, string destinations)
        {
            if (index >= 0 && index < destinations.Length)
            {
                destinations = destinations.Insert(index, newStop);
            }

            Console.WriteLine(destinations);
            return destinations;
        }

        static string RemoveStop(int startIndex, int endIndex, string destinations)
        {
            if (startIndex >= 0 && endIndex < destinations.Length)
            {
                destinations = destinations.Remove(startIndex, endIndex - startIndex + 1);
            }

            Console.WriteLine(destinations);
            return destinations;
        }

        static string Switch(string oldString, string newString, string destinations)
        {
            if (destinations.Contains(oldString))
            {
                destinations = destinations.Replace(oldString, newString);
            }

            Console.WriteLine(destinations);
            return destinations;
        }
    }
}
