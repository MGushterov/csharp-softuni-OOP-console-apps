﻿namespace PersonsInfo
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Team
    {
        private string name;
        private readonly List<Person> firstTeam;
        private readonly List<Person> reserveTeam;


        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public IReadOnlyCollection<Person> FirstTeam
        { get { return firstTeam.AsReadOnly(); } }

        public IReadOnlyCollection<Person> ReserveTean
        { get { return reserveTeam.AsReadOnly(); } }

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
        }

        public override string ToString()
        {
            return $"First team has {firstTeam.Count} players.{Environment.NewLine}Reserve team has {reserveTeam.Count} players.";
        }
    }
}
