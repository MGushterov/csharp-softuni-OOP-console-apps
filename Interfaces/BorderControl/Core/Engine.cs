namespace BorderControl.Core
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

        private ICollection<IIdentifiable> citizensEntering;

        public Engine()
        {
            citizensEntering = new List<IIdentifiable>();
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
                if (args.Length == 2)
                {
                    string model = args[0];
                    string id = args[1];
                    citizensEntering.Add(new Robot(id, model));
                }
                else if (args.Length == 3)
                {
                    string name = args[0];
                    int age = int.Parse(args[1]);
                    string id = args[2];
                    citizensEntering.Add(new Person(name, id, age));
                }
            }

            string searchedIdEndingNumbers = reader.ReadLine();
            foreach (var citizen in citizensEntering)
            {
                if (citizen.Id.EndsWith(searchedIdEndingNumbers))
                {
                    writer.WriteLine(citizen.Id);
                }
            }
        }
    }
}
