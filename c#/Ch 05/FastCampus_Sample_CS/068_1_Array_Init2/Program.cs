﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _068_1_Array_Init2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrNum = new int[3];
            int[] arrNum2 = new int[] { 0, 1, 2 };
            int[] arrNum3 = new int[3] {0, 1, 2 };
            int[] arrNum4 = { 0, 1, 2 };

            string[] arrWeek = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            Array.Clear(arrNum, 0, arrNum.Length);
            for (int i = 0; i < arrNum.Length; i++)
            {
                arrNum[i] = i;
            }
            for (int i = 0; i < arrNum2.Length; i++)
            {
                Console.Write("{0}", arrNum[i]);
            }

            Console.WriteLine("\n----------------------------------------");

            Console.WriteLine("arrNum3 : ");
            foreach (int temp in arrNum3)
            {
                Console.Write("{0}", temp);
            }

            Console.WriteLine("\n----------------------------------------");

            Console.WriteLine("arrNum4 : ");
            foreach (int temp in arrNum4)
            {
                Console.Write("{0}", temp);
            }

            Console.WriteLine("\n----------------------------------------");

            foreach(string tempStr in arrWeek)
            {
                Console.Write("{0}", tempStr);
            }
        }
    }
}
