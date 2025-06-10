namespace BorderControl.IO
{
    using System;

    using IO.Interfaces;
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            string line = Console.ReadLine();
            return line;
        }
    }
}
