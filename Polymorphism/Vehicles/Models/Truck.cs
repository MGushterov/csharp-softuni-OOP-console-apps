namespace Vehicles.Models
{
    using System;

    using Interfaces;
    public class Truck : IVehicle
    {
        public Truck(double fuel, double consumption)
        {
            this.FuelQuantity = fuel;
            this.Consumption = consumption;
        }

        public double FuelQuantity { get; private set; }

        public double Consumption { get; private set; }

        public void Drive(double km)
        {
            if (this.FuelQuantity - (this.Consumption + 1.6) * km >= 0)
            {
                this.FuelQuantity -= (this.Consumption + 1.6) * km;
                Console.WriteLine($"Truck travelled {km} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public void Refuel(double liters)
        {
            this.FuelQuantity += liters * 0.95;
        }
    }
}
