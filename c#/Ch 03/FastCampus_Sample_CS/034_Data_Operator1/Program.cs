using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _033_Check
 * DESC : 산술 연산자, +, -, *, /, % (모든 수치 데이터 형태)
--------------------------------------------------------------------------- */

namespace _034_Data_Operator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine("c : " + c); // 콘솔에 "c: 24"라고 출력됨

            Console.WriteLine("100 - 10 = " + (100 - 10)); // 콘솔에 "100 - 10 = 90"라고 출력됨

            int d = a / b;
            Console.WriteLine("d : " + d); // 콘솔에 "d: 3"라고 출력됨

            int e = a * (b + c);
            Console.WriteLine("e : " + e); // 콘솔에 "e: 540"라고 출력됨

            int f = (a + b) % 2;
            Console.WriteLine("f : " + f); // 콘솔에 "f: 0"라고 출력됨
        }
    }
}