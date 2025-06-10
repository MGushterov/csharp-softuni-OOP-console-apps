namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        private const double DefaultFuelConsumptionRaceMotorcycle = 8;
        public RaceMotorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
            this.FuelConsumption = DefaultFuelConsumptionRaceMotorcycle;
        }
    }
}
