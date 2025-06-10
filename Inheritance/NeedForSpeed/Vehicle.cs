namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            this.FuelConsumption = DefaultFuelConsumption;
            this.Fuel = fuel;
            this.HorsePower = horsePower;
        }

        protected const double DefaultFuelConsumption = 1.25;

        public double FuelConsumption { get; set; }

        public double Fuel { get; set; }

        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            this.Fuel -= kilometers * this.FuelConsumption;
        }

    }
}
