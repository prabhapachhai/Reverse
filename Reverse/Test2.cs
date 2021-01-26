using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse
{
    class Test2
    {
        public static void Revrse2()
        {
            //5.write a c# program to reverse a given array of integers and length 
            // sample input{ 10,20,-30,-40,50}
            //Reverse array: 50 -40 -30 20 10
            int[] array = { 10, 20, -30, -40, 50 };
           // int[] array = { 1, 2, 3 };
            Array.Reverse(array);
            Console.WriteLine(string.Join(' ', array));
        }
        //public static void Reverse3(int []nums)
        //{
        //    int[]  temp = new int[5];
        //    int j = nums.Length-1;
        //    foreach (int n in nums )
        //    {
        //        temp[j] = n;

        //        j--;
        //    }
        //    foreach (int n in temp )
        //    {
        //        Console.Write( n+" ", " ");

        //    }
            

            }
        }
    

