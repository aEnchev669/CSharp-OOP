


namespace BorderControl.Models
{
    using Validation;
    using Interfaces;
    using System.ComponentModel.DataAnnotations;

    public class Robots : IRobots
    {
        public string Model { get; private set; }

        public string Id { get; private set; }
        public Robots(string model, string id)
        {
            Model = model;
            Id = id;
        }
        
    }
}
