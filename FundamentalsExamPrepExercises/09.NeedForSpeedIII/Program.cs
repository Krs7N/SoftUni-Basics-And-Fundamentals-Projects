using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.NeedForSpeedIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAXIMUM_FUEL_IN_TANK = 75;

            int numberOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInformation = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
                string carName = carInformation[0];
                int carMileage = int.Parse(carInformation[1]);
                int carFuel = int.Parse(carInformation[2]);

                Car car = new Car(carName, carMileage, carFuel);

                cars.Add(car);
            }

            string[] commands = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "Stop")
            {
                string action = commands[0];

                switch (action)
                {
                    case "Drive":
                        Drive(commands[1], int.Parse(commands[2]), int.Parse(commands[3]), cars);
                        break;
                    case "Refuel":
                        Refuel(commands[1], int.Parse(commands[2]), cars, MAXIMUM_FUEL_IN_TANK);
                        break;
                    case "Revert":
                        Revert(commands[1], int.Parse(commands[2]), cars);
                        break;
                }

                commands = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join("\n", cars));
        }



        static void Drive(string carName, int distance, int fuel, List<Car> cars)
        {
            Car curCar = cars.First(c => c.Name == carName);

            if (fuel > curCar.Fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
            else
            {
                curCar.Mileage += distance;
                curCar.Fuel -= fuel;
                Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
            }

            if (curCar.Mileage >= 100000)
            {
                cars.Remove(curCar);
                Console.WriteLine($"Time to sell the {carName}!");
            }
        }

        static void Refuel(string carName, int fuel, List<Car> cars, int maximumFuelInTank)
        {
            Car curCar = cars.First(c => c.Name == carName);

            int initialFuel = curCar.Fuel;

            if (curCar.Fuel + fuel >= maximumFuelInTank)
            {
                curCar.Fuel = maximumFuelInTank;
            }
            else
            {
                curCar.Fuel += fuel;
            }

            Console.WriteLine($"{carName} refueled with {curCar.Fuel - initialFuel} liters");
        }

        static void Revert(string carName, int kilometers, List<Car> cars)
        {
            Car curCar = cars.First(c => c.Name == carName);

            curCar.Mileage -= kilometers;

            if (curCar.Mileage < 10000)
            {
                curCar.Mileage = 10000;
            }
            else
            {
                Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
            }

        }
    }

    class Car
    {
        public Car(string carName, int carMileage, int carFuel)
        {
            Name = carName;
            Mileage = carMileage;
            Fuel = carFuel;
        }

        public string Name { get; set; }

        public int Mileage { get; set; }

        public int Fuel { get; set; }

        public override string ToString()
        {
            return $"{Name} -> Mileage: {Mileage} kms, Fuel in the tank: {Fuel} lt.";
        }
    }
}