namespace Restaurant
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            Cake ChocolateCake = new Cake("Chocolate cake");
            Fish fish = new Fish("Smoked salmon", 18.57m);
            Coffee coffee = new Coffee("Double caramel latte", 20);
            Console.WriteLine(fish.Grams);
        }
    }
}
