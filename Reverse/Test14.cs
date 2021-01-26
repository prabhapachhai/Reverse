using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse
{
    class Test14
    {
        public static void Average()
      {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2 + num3 + num4;
            int average = sum / 4;
            Console.WriteLine("inter the 4 number");
            Console.WriteLine("value of average  is:" + average);
        }
    }
}
