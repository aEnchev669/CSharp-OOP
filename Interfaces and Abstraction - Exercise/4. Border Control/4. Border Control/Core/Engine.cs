

namespace BorderControl.Core
{
    using System;
    
    using Models;
    using Interfaces;
    using Models.Interfaces;
    using System.Collections.Generic;

    public class Engine : IEngine
    {

        Ids allIds = new Ids();
        
        public void Start()
        {
            string command = Console.ReadLine();
            while (command != "End")
            {
               
                string[] cmdArgs = command.Split(' ');
                if (cmdArgs.Length == 3)
                {
                    string name = cmdArgs[0];
                    int age = int.Parse(cmdArgs[1]);
                    string id = cmdArgs[2];
                    
                    allIds.IdsValid.Add(id);

                    Citizen citizen = new Citizen(name, age, id);
                }
                else if (cmdArgs.Length == 2)
                {
                    string model = cmdArgs[0];
                    string id = cmdArgs[1];
                    allIds.IdsValid.Add(id);

                    Robots robot = new Robots(model, id);
                }
                command = Console.ReadLine();
            }
            string idToCheck = Console.ReadLine();
            allIds.ValidateId(idToCheck);
            
        }
    }
}
