using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.VehicleCatalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            List<Vehicle> vehicles = new List<Vehicle>();

            while (tokens[0] != "End")
            {
                Vehicles typeOfVehicle;
                bool isVehicle = Enum.TryParse(tokens[0], true, out typeOfVehicle);

                if (isVehicle)
                {
                    string model = tokens[1];
                    string color = tokens[2];
                    int horsePower = int.Parse(tokens[3]);

                    Vehicle vehicle = new Vehicle(typeOfVehicle, model, color, horsePower);

                    vehicles.Add(vehicle);
                }

                tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            string command = Console.ReadLine();

            while (command != "Close the Catalogue")
            {
                Vehicle desiredVehicle = vehicles.FirstOrDefault(vehicle => vehicle.Model == command);

                Console.WriteLine(desiredVehicle);

                command = Console.ReadLine();
            }

            List<Vehicle> cars = vehicles.Where(car => car.Type == Vehicles.Car).ToList();
            List<Vehicle> trucks = vehicles.Where(truck => truck.Type == Vehicles.Truck).ToList();

            double carAvgHorsePower = cars.Count > 0 ? cars.Average(car => car.HorsePower) : 0.00;
            double truckAvgHorsePower = trucks.Count > 0 ? trucks.Average(truck => truck.HorsePower) : 0.00;

            Console.WriteLine($"Cars have average horsepower of: {carAvgHorsePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAvgHorsePower:f2}.");
        }
    }

    enum Vehicles
    {
        Truck,
        Car
    }

    class Vehicle
    {
        public Vehicle(Vehicles type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public Vehicles Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {Type}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {HorsePower}");

            return sb.ToString().TrimEnd();
        }
    }
}
