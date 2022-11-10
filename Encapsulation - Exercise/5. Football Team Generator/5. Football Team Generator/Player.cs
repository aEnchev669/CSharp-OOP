using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameCantBeNullOrWhiteSpace);
                }
                name = value;

            }
        }

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {

            Name = name;
            this.Stats = new Stats(endurance, sprint, dribble, passing, shooting);

        }

        public Stats Stats { get; private set; }

        public double OverallRating => (this.Stats.Endurance + this.Stats.Sprint + this.Stats.Dribble + this.Stats.Passing + this.Stats.Shooting) / 5.0;
    }
}
