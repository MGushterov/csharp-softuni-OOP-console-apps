namespace CustomRandomList
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            RandomList list = new RandomList();
            list.Add("Mercedes");
            list.Add("BMW");
            list.Add("VW");
            list.Add("Alpha Romeo");
            list.Add("Lancia");
            list.Add("Hyundai");
            Console.WriteLine(list.RandomString());
        }
    }
}
