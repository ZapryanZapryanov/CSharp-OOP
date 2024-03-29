﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
   public class Team
    {
        private string name;
        private readonly List<Person> firstTeam;
        private readonly List<Person> reserveTeam;
        public string Name { get => this.name; private set => this.name = value; }
        public IReadOnlyCollection<Person> FirstTeam => this.firstTeam;
        public IReadOnlyCollection<Person> ReserveTeam => this.reserveTeam;
        public Team(string name)
        {
            this.Name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }
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

    }
}
