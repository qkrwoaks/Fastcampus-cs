using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _035_Operator2
 * DESC : 산술 연산자, +, -, *, /, % (모든 수치 데이터 형태)
--------------------------------------------------------------------------- */

namespace _035_Operator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 3;
            float c = 123.45f, d = 3.1456f;

            Console.WriteLine("a : " + a); // 콘솔에 "a: 10"라고 출력됨
            Console.WriteLine("b : " + b); // 콘솔에 "b: 3"라고 출력됨
            Console.WriteLine("c : " + c); // 콘솔에 "c: 123.45"라고 출력됨
            Console.WriteLine("d : " + d); // 콘솔에 "d: 3.1456"라고 출력됨

            Console.WriteLine("\n정수의 계산");
            Console.WriteLine("a + b = " + (a + b)); // 콘솔에 "a + b = 13"라고 출력됨
            Console.WriteLine("a - b = " + (a - b)); // 콘솔에 "a - b = 7"라고 출력됨
            Console.WriteLine("a * b = " + (a * b)); // 콘솔에 "a * b = 30"라고 출력됨
            Console.WriteLine("a / b = " + (a / b)); // 콘솔에 "a / b = 3"라고 출력됨
            Console.WriteLine("a % b = " + (a % b)); // 콘솔에 "a % b = 1"라고 출력됨
        }
    }
}