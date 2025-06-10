namespace NeedForSpeed
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            CrossMotorcycle cross = new CrossMotorcycle(90, 60);
            SportCar lambo = new SportCar(220, 240);
            cross.Drive(30);
            lambo.Drive(15);
            Console.WriteLine(cross.Fuel);
            Console.WriteLine(lambo.Fuel);
        }
    }
}
