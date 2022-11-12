using System;

namespace Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string invalidId = "0231";
            string id = "231231210231";

             bool isValid = false;
            if (id.EndsWith(invalidId))
            {
                isValid = true;
            }
            Console.WriteLine(isValid);
            
        }
    }
}
