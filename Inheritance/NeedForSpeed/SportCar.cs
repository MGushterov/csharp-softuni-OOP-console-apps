namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const double DefaultFuelConsumptionSportCar = 10;

        public SportCar(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
            this.FuelConsumption = DefaultFuelConsumptionSportCar;
        }
    }
}
