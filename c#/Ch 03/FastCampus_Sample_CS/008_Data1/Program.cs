using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _008_Data1
 * DESC : 정수형 데이터 기초
--------------------------------------------------------------------------- */

namespace _008_Data1
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 120;
            byte b = 255;
            short c = 30000;
            long d = 100000000000;
            ulong f = 10000000000000000;
            int num = 100;

            Console.WriteLine("sbyte a : " + a); // 콘솔에 "sbyte a : 120" 라고 출력됨
            Console.WriteLine("byte b : " + b); // 콘솔에 "byte b : 255" 라고 출력됨
            Console.WriteLine("short c : " + c); // 콘솔에 "short c : 30000" 라고 출력됨
            Console.WriteLine("long d : " + d); // 콘솔에 "long d : 100000000000" 라고 출력됨
            Console.WriteLine("ulong f : " + f); // 콘솔에 "ulong f : 10000000000000000" 라고 출력됨
            Console.WriteLine("int num : " + num); // 콘솔에 "int num : 100" 라고 출력됨
        }
    }
}
