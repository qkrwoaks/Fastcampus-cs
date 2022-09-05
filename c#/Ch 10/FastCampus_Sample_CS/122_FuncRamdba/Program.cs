﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122_FuncRamdba
{
    delegate void dPrint(string str);
    delegate void dFunc();

    internal class Program
    {
        static public void CallPrint(string str)
        {
            Console.WriteLine(str);
        }

        static public void CallBackFunc(dPrint dp, string msg)
        {
            if (null != dp)
            {
                dp("CallBackFunc : " + msg);
            }
        }

        static void Main(string[] args)
        {
            CallBackFunc(CallPrint, "Hello"); // 함수 연결
            CallBackFunc(delegate (string str) { Console.WriteLine(str); }, "Hello"); // delegate 직접    
            CallBackFunc((string str) => { Console.WriteLine(str); }, "Hello"); // 람다의 식형별
            CallBackFunc((str) => Console.WriteLine(str), "Hello"); // 람다식 기본..
            CallBackFunc(str => Console.WriteLine(str), "Hello"); // 람다식 기본..

            dFunc dfunc = () => Console.WriteLine("No Params"); // 파라미터가 없는 경우 () 반드시 사용 
        }
    }
}
