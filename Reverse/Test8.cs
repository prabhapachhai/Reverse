using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse
{
    class Test8
    {
        public static void WholeSentenceRev(string text)
        {
            char[] words = text.ToCharArray();
            Array.Reverse(words);
            text = string.Join(" ", words);
            Console.WriteLine(words);
        }
    }
}
