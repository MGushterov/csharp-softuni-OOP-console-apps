namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        protected const double DefaultFuelConsumptionCar = 3;

        public Car(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
            this.FuelConsumption = DefaultFuelConsumptionCar;
        }
    }
}
