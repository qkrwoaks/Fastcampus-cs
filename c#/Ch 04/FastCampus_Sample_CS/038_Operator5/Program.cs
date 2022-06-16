﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _038_Operator5
 * DESC : 
 * 조건부 논리  '&&', '||'
 * 논리 부정 연산자 '!'
--------------------------------------------------------------------------- */

namespace _038_Operator5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int a = 100;
            int b = 1000;

            result = a == 100 && b == 1000;
            Console.WriteLine(result);

            result = a == 100 || b == 1000;
            Console.WriteLine(result);

            result = a == 100 && b == 100;
            Console.WriteLine(result);

            result = a == 100 || b == 100;
            Console.WriteLine(result);
        }
    }
}
