namespace Vehicles.Models.Interfaces
{
    public interface IVehicle
    {
        double FuelQuantity { get; }

        double Consumption { get; }

        void Drive(double km);

        void Refuel(double liters);
    }
}
