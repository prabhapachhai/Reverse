using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse
{
    class Test3
    {
        public static void Stringrev(string str)
        {
            string a = "mkt";
            int n = str.Length;
            char[] i = str.ToCharArray();
            Array.Reverse(i);
            Console.WriteLine(i);
        }
    }
}
