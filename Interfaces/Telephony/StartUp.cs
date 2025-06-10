
namespace Telephony
{
    using System;
    using System.Linq;
    using Models;
    using Models.Interfaces;
    using IO;
    using IO.Interfaces;
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
