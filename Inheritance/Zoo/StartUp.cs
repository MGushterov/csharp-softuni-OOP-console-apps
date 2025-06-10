namespace Zoo
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            Snake snake = new Snake("Slyderin");
            Console.WriteLine(snake.Name);
        }
    }
}
