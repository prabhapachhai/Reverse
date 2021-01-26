using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse
{
    class Test5
    {
      public   static void FrontAndBack()
        {
            // write a c# program to create a new string from a given string (length 1 or more) 
            //with the first character added at the front and back.input a string :
            //the quick brown fox jumps over the lazy dog.
            //out put : tthe quick brown fox jumps over the lazy dog.t

            int startindex = 0;
            int length = 1;
            Console.WriteLine("input a string:");
            string input = Console.ReadLine();
            var s = input.Substring(startindex, length);
            Console.WriteLine(s+input+s);
        }
    }
}
