using System;
using System.Collections.Generic;

namespace boxing_unboxingNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            List<object> emptyList = new List<object>();
            emptyList.Add(7);
            emptyList.Add(28);
            emptyList.Add(-1);
            emptyList.Add(true);
            emptyList.Add("chair");
            for (var i = 0; i < emptyList.Count; i++)
            {
                Console.WriteLine("The items in my list are: {0}", emptyList[i]);
            }
            foreach(var item in emptyList)
            {
                if(item is int)
                {
                    sum += (int)item;
                }
                
            }
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("Hello World!");
        }
    }
}
