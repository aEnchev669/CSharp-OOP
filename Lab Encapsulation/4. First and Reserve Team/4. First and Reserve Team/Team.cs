﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        

        private List<Person> firstTeam;
        public IReadOnlyCollection<Person> FirstTeam
        {
            get 
            {
                return this.firstTeam.AsReadOnly(); 
            }

        }

        private List<Person> reserveTeam;
        public IReadOnlyCollection<Person> ReserveTeam
        {
            get
            {
                return this.reserveTeam.AsReadOnly();
            }
        }

        public Team(string name )
        {
            this.name = name;
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
        public override string ToString()
        {
            return $"First team has {firstTeam.Count} players."
                   + Environment.NewLine +
                   $"Reserve team has {reserveTeam.Count} players.";
        }
    }
}
