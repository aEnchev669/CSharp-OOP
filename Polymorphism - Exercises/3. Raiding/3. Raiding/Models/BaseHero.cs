using Raiding.Models.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public abstract class BaseHero : IBaseHero
    {
        public int PowersPoints { get; set; }
        public string Name { get; private set; }

        public int Power { get; private set; }
        public BaseHero( string name, int power)
        {
            
            Name = name;
            Power = power;
        }

        public virtual string CastAbility(string type, string name, int power)
        {
            string output = string.Empty;
            if (type == "Druid" || type == "Paladin")
            {
                output = $"{type} - {name} healed for {power}";
            }
            else if (type == "Rogue" || type == "Warrior")
            {
                output = $"{type} - {name} hit for {power} damage";
            }
            PowersPoints += power;
            return output;
        }

        public string IsBoosDeath(int powerOfTheBoss)
        {
            if (PowersPoints > powerOfTheBoss)
            {
                return "Victory!";
            }
            return "Defeat...";
        }

    }
}
