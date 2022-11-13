using System;
using System.Collections;
using System.Collections.Generic;

namespace Is
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IEnumerable collection = new Queue<int>();
            //List<int> list = null;
            //if (collection is List<int>)
            //{
            //list = (List<int>)collection;
            //Console.WriteLine(list.Count);
            //}


            IEnumerable collection = new List<int>();
            List<int> list = collection as List<int>;

            if (list != null)
            {

                Console.WriteLine(list.Count);
            }

        }


    }
}
