namespace PlayersAndMonsters
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            BladeKnight knight = new BladeKnight("Hector", 100);
            Console.WriteLine(knight);
        }
    }
}
