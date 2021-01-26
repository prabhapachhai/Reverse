using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse
{
    class Test7
    {
        public static void AlphabetPattern()
        {
            //write a c# program to find the longest word in a string 
            //test data write a c# program to display the following pattern using the alphabet.
            //    output: following 
            Console.WriteLine("space seperated string ");
            string sentence = "write a c# program to display the following pattern using the alphabet";
            string[] words = sentence.Split(" ");
            foreach (  string text in words )
                Console.WriteLine(text);
            {

            }
        }
    }
}
