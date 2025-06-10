
namespace Vehicles
{
    using System;

    using Models;
    using Models.Interfaces;
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(' ');
            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            string[] truckInfo = Console.ReadLine().Split(' ');
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int iterations = int.Parse(Console.ReadLine());
            for (int i = 0; i < iterations; i++)
            {
                string[] command = Console.ReadLine().Split();
                string vehicle = command[1]; 
                string action = command[0];
                double distanceOrFuel = double.Parse(command[2]);
                if (vehicle is "Car")
                {
                    if (action is "Drive")
                    {
                        car.Drive(distanceOrFuel);
                    }
                    else if (action is "Refuel")
                    {
                        car.Refuel(distanceOrFuel);
                    }
                }
                else if (vehicle is "Truck")
                {
                    if (action is "Drive")
                    {
                        truck.Drive(distanceOrFuel);
                    }
                    else if (action is "Refuel")
                    {
                        truck.Refuel(distanceOrFuel);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
