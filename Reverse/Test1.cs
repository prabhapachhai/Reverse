using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse
{
    class Test1
    {
        public static string EXC(string str1)
        {
            // ques1. write a c# program to exchange the first and last characters in a given string andreturn the new string.
            //sample input:
            //"abcd"
            //"a"
            //"xy"
            //expected output: 
            //dbca,a,yx

            string first;
            string mid;
            string last;
            if (str1.Length > 1)
            {
                first = str1.Substring(0, 1);
                last = str1.Substring(str1.Length - 1);
                mid = str1.Substring(1, str1.Length - 2);
                str1 = last + mid + first;
            }
            
            return str1;
        }
    }
}
