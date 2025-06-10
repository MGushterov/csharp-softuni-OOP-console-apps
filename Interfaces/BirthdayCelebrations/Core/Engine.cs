namespace BirthdayCelebrations.Core
{
    using System;
    using System.Collections.Generic;

    using Models;
    using Models.Interfaces;
    using IO.Interfaces;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private ICollection<IBirthable> citizens;

        public Engine()
        {
            citizens = new List<IBirthable>();
        }

        public Engine(IReader reader, IWriter writer) : this()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Start()
        {
            string command;
            while ((command = reader.ReadLine()) != "End")
            {
                string[] args = command.Split(' ');
                string identifier = args[0];
                if (identifier == "Robot")
                {
                    continue;
                }
                else if (identifier == "Citizen")
                {
                    string name = args[1];
                    int age = int.Parse(args[2]);
                    string id = args[3];
                    string birthdate = args[4];
                    citizens.Add(new Person(name, id, age, birthdate));
                }
                else if (identifier == "Pet")
                {
                    string name = args[1];
                    string birthdate = args[2];
                    citizens.Add(new Pet(name, birthdate));
                }
            }

            string searchedYearOfBirth = reader.ReadLine();

            foreach (var citizen in citizens)
            {
                if (citizen.Birthdate.EndsWith(searchedYearOfBirth))
                {
                    writer.WriteLine(citizen.Birthdate);
                }
            }
        }
    }
}
