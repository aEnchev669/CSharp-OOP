using System;

namespace TypeTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type compileTimeType = typeof(DateTime);

            Type runtimeType = Type.GetType(Console.ReadLine());

            Console.WriteLine(runtimeType.FullName);
        }
    }
}
