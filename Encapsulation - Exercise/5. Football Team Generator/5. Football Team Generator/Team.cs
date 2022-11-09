using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameCantBeNullOrWhiteSpace);
                }
                name = value;
            }
        }

        private List<Player> players;
        private Team()
        {
            this.players = new List<Player>();
        }
        public Team(string name) : this()
        {
            Name = name;
        }
        public int Rating => this.players.Count > 0 ?
            (int)Math.Round(this.players.Average(p => p.OverallRating), 0) : 0;
        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            Player playerToRemove = this.players
                .FirstOrDefault(p => p.Name == playerName);

            if (playerToRemove == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.NameCantBeFound, playerName, this.Name));
            }
            this.players.Remove(playerToRemove);
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}
