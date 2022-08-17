﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _078_Constructor
{
    class AA
    {
        int a;
        float f;

        /// <summary>
        /// 생성자
        /// </summary>
        public AA()
        {
            a = 0;
            f = 0f;
            Console.WriteLine(" Call Constructor ");
            Console.WriteLine(" a : {0}", a);
            Console.WriteLine(" f : {0}", f);
        }

        public AA(int _a)
        {
            a = _a;
            Console.WriteLine(" Call Constructor");
            Console.WriteLine(" a : {0}", a);
            Console.WriteLine(" f : {0}", f);
        }

        public AA(int _a, float _f)
        {
            a = _a;
            f = _f;

            Console.WriteLine(" Call Constructor ");
            Console.WriteLine(" a : {0}", a);
            Console.WriteLine(" f : {0}", f);
        }

        /// <summary>
        /// 소멸자
        /// </summary>
        ~AA()
        {
            Console.WriteLine(" Call Destructor");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            AA aaa = new AA(10);
            AA aaaa = new AA(100, 0.5f);
        }
    }
}
