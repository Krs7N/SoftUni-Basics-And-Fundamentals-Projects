using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            string[] tokens = Console.ReadLine().Split('/', StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0] != "end")
            {
                string typeOfVehicle = tokens[0];

                switch (typeOfVehicle)
                {
                    case "Car":
                        Car car = new Car
                        {
                            Brand = tokens[1],
                            Model = tokens[2],
                            HorsePower = int.Parse(tokens[3])
                        };
                        catalog.Cars.Add(car);
                        break;
                    case "Truck":
                        Truck truck = new Truck
                        {
                            Brand = tokens[1],
                            Model = tokens[2],
                            Weight = int.Parse(tokens[3])
                        };
                        catalog.Trucks.Add(truck);
                        break;
                }

                tokens = Console.ReadLine().Split('/', StringSplitOptions.RemoveEmptyEntries);
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                List<Car> orderedCars = catalog.Cars.OrderBy(c => c.Brand).ToList();
                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                List<Truck> orderedTrucks = catalog.Trucks.OrderBy(t => t.Brand).ToList();
                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }

    }

    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
    }
}
