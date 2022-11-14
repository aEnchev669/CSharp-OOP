using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Exceptions
{
    public  class InvalidAnimalTypeException : Exception
    {
        private const string DefaultMessage = "Invalid animal type";
        public InvalidAnimalTypeException() : base(DefaultMessage)
        {

        }

        public InvalidAnimalTypeException(string message) : base(message)
        {

        }
    }
}
