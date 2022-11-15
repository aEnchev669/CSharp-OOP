using System;

namespace _1._Square_Root
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            try
            {
                if (number <= 0)
                {
                    throw new Exception("Invalid number.");
                }
                Console.WriteLine(Math.Sqrt(number));
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Goodbye.");
        }
    }
}
