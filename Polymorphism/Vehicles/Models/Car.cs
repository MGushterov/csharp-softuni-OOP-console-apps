namespace Vehicles.Models
{
    using System;

    using Models.Interfaces;
    public class Car : IVehicle
    {
        public Car(double fuel, double consumption)
        {
            this.FuelQuantity = fuel;
            this.Consumption = consumption;
        }

        public double FuelQuantity { get; private set; }

        public double Consumption { get; private set; }

        public void Drive(double km)
        {
            if (this.FuelQuantity - (this.Consumption + 0.9) * km >= 0)
            {
                this.FuelQuantity -= (this.Consumption + 0.9) * km;
                Console.WriteLine($"Car travelled {km} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }
    }
}
