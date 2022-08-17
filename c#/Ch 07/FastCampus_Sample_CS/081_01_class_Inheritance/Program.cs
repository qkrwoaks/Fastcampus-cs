﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _081_01_class_Inheritance
{
    class Super 
    {
        protected int a;

        public void Print()
        {
            Console.WriteLine("Super Print()");
        }
    }

    class Sub : Super
    {
        int b;

        public void Print()
        {
            Console.WriteLine("Sub Print() a : {0}, b : {1}", a, b);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {   
            Super super = new Super();
            Sub sub = new Sub();
            sub.Print();
        }
    }
}
