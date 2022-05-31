using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _007_Variable2
 * DESC : 변수 선언에 다양한 방법..
--------------------------------------------------------------------------- */

namespace _007_Variable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100; // 선언과 동시에 초기화
            int y = 200;
            int a = 1000, b = 2000;

            Console.WriteLine("x : {0}", x); // 콘솔에 "x: 100" 라고 출력됨
            Console.WriteLine("y : " + y); // 콘솔에 "y: 200" 라고 출력됨
            Console.WriteLine("a : " + a); // 콘솔에 "a: 1000" 라고 출력됨
            Console.WriteLine("b : " + b); // 콘솔에 "b: 2000" 라고 출력됨
        }
    }
}