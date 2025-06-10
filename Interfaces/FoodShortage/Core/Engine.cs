namespace FoodShortage.Core
{
    using System;
    using System.Collections.Generic;

    using Models;
    using Models.Interfaces;
    using IO.Interfaces;
    using System.Linq;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private ICollection<IHuman> citizens;

        public Engine()
        {
            citizens = new List<IHuman>();
        }

        public Engine(IReader reader, IWriter writer) : this()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Start()
        {
            int citizensCount = int.Parse(reader.ReadLine());   
            for (int i = 0; i < citizensCount; i++)
            {
                string[] citizenArgs = reader.ReadLine().Split(' ');
                string name = citizenArgs[0];
                int age = int.Parse(citizenArgs[1]);
                if (citizenArgs.Length == 3)
                {
                    string group = citizenArgs[2];
                    citizens.Add(new Rebel(name, age, group));
                }
                else if (citizenArgs.Length == 4)
                {
                    string id = citizenArgs[2];
                    string birthdate = citizenArgs[3];
                    citizens.Add(new Person(name, age, id, birthdate));
                }
            }
            string command;
            while ((command = reader.ReadLine()) != "End")
            {
                if (citizens.Any(x => x.Name == command))
                {
                    IHuman citizen = citizens
                        .FirstOrDefault(citizen => citizen.Name == command);
                    citizen.BuyFood();
                }
            }
            int foodSum = 0;
            foreach (var citizen in citizens)
            {
                foodSum += citizen.Food;
            }

            writer.WriteLine(foodSum.ToString());
        }
    }
}
