using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse
{
    class Test4
    {
        public static void RevNum(int N)

        {
            //n a = 123;
            int n = N;
            char[] i = n.ToString().ToCharArray();
            Array.Reverse(i);
            Console.WriteLine(i);
        }

    }
}

