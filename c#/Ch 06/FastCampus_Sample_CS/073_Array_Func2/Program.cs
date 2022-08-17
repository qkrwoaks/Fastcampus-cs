﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _073_Array_Func2
{
    internal class Program
    {
        static int[] CreateIntArray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
                array[i] = 0;
            return array;
        }

        static string[] CreateStrArray(int size)
        {
            string[] array = new string[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = string.Empty;
            }

            return array;
        }

        static int[,] CreateIntArray()
        {
            int[,] array = new int[3, 2];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    array[i, j] = 0;
                }
            }
            return array;
        }

        static void Main(string[] args)
        {
            int[] arrNum = CreateIntArray(3);
            string[] strName = CreateStrArray(5);
            int[,] array = CreateIntArray();

            foreach (int temp in arrNum)
            {
                Console.Write("  {0}", temp);
            }

            Console.WriteLine("\n----------------");

            arrNum[0] = 1000;
            foreach (int temp in arrNum)
            {
                Console.Write("  {0}", temp);
            }

            Console.WriteLine("\n----------------");

            foreach (string s in strName)
            {
                Console.WriteLine("strName : {0}", s);
            }

            Console.WriteLine("\n----------------");

            strName[0] = "Hello World";
            strName[1] = "!!!";

            foreach (string s in strName)
            {
                Console.WriteLine("strName : {0}", s);
            }

            Console.WriteLine("\n----------------");

            foreach (int data in array)
            {
                Console.WriteLine("data : {0}", data);
            }

            array[0, 0] = 10;
            array[2, 0] = 10;

            Console.WriteLine("\n----------------");

            foreach (int data in array)
            {
                Console.WriteLine("data : {0}", data);
            }
        }
    }
}
