namespace CustomStack
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        static void Main()
        {
            StackOfStrings stack = new StackOfStrings();
            string[] collection = new string[]
            {
                "Misho",
                "Fipo",
                "Dostin",
                "Simo",
                "Niki"
            };
            stack.AddRange(collection);
            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
