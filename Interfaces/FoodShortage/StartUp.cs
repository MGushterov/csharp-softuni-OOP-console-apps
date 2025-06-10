
namespace FoodShortage
{
    using System;
    using IO.Interfaces;
    using IO;
    using Core;

    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            Engine engine = new Engine(reader, writer);
            engine.Start();
        }
    }
}
