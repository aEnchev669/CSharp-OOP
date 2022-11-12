

namespace BorderControl.Models
{
    using System;
    using System.Collections.Generic;
    using Validation;
    public class Ids : Validators
    {


        public List<string> IdsValid { get ; set ; }
        public Ids()
        {
           IdsValid = new List<string>();
        }
        
        
        public void ValidateId(string fakeId)
        {
            foreach (var id in IdsValid)
            {
                if (id.EndsWith(fakeId))
                {
                    Console.WriteLine(id);
                }
            }
        }
    }
}
