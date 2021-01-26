using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse
{
    class Test6
    {
        public static void Remove()
        {
            // 1. write a c# program remove specified a character from a non -empty string
            //test data:ABCD1111EFGH string 
            Console.WriteLine("origin value before remove");
            string input = Console.ReadLine();
            string value = input.Replace("1111", "");
            Console.WriteLine("new value after Remove:"+value);
            
           

        }
    }
}
