using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse
{
    class Test13
    {
       public static void Temperature()
        {
            double c = Convert.ToInt32(Console.ReadLine());

            double kelvin = c + 273.15;
            double fahrenheit = (c * 9 / 5) + 32;
            Console.WriteLine(" enter the value of kelvin" + kelvin);
            Console.WriteLine("enter the value of fahrenhait" + fahrenheit);

        }
    }
}
