using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse
{
    class Test12
    {
        public static void LeapYear()
        {

            // Write a c# program to find whether a given year is a leap year or not.  test data:2016 , expected output : 2016 is a leap year.
            int y;
            Console.WriteLine("enter a  year ");
            y = Convert.ToInt32(Console.ReadLine());
            if (y % 4 == 0)   /*4 digit of year , if is devided by 4 reminder is equal to zero means leap year */
            {
                Console.WriteLine("{0} is a leap year ", y);

            }
            else
            {
                Console.WriteLine("{0} is  not a leap year ", y);
            }
            Console.WriteLine("division of year by 4 is :" + 0);
        }
    }
}
