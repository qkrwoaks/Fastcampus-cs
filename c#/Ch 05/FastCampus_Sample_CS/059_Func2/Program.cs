using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _059_Func2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            num += Add(); // 1

            Console.WriteLine("Num : " + num);
            Console.WriteLine("입력하신 정수는 {0} 입니다.", InputNum());
        }

        static int Add() 
        {
            int a = 0;
            return ++a;
        }

        static int InputNum()
        {
            Console.Write("정수를 입력하세요 : ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        
    }
}
