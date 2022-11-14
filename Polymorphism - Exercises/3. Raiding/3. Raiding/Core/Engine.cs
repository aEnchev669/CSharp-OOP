using Raiding.Core.Interfaces;
using Raiding.IO.Interfaces;
using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
           
        }
        public void Run()
        {
            
            int countOfHeroes = int.Parse(reader.ReadLine());
            for (int i = 0; i < countOfHeroes; i+=2)
            {
                string heroName = reader.ReadLine();
                string heroType = reader.ReadLine();
                if (heroType == "Paladin")
                {
                    Paladin paladin = new Paladin(heroName, 80);
                    
                }
                else if (heroType == "Druid")
                {
                    Druid druid = new Druid(heroName, 100);
                }
                else if (heroType == "Rogue")
                {
                    Rogue rogude = new Rogue(heroName, 80);
                }
                else if (heroType == "Warrior")
                {
                    Warrior warrior = new Warrior(heroName, 100);
                }
            }

            int powerOfTheBoss = int.Parse(reader.ReadLine());

            
        }

    }
}
