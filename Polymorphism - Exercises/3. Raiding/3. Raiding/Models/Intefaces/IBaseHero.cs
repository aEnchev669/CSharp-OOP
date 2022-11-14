using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models.Intefaces
{
    public interface IBaseHero
    {
        public string Name { get; }
        public int Power { get;}
        string CastAbility(string type, string name, int power);
    }
}
