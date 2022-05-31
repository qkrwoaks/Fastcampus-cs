using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _011_Data4
 * DESC : 2진수 리터럴 접두사0b (0B), 16진수 리터럴 접두사 0x(OX)
--------------------------------------------------------------------------- */

namespace _011_Data4
{
     class Program
    {
        static void Main(string[] args)
        {
            int a = 0b11111111; // 2진수 리터럴 접두사0b (OB)
            int b = 0xFF; // 16진수 리터럴 접두사0x(OX)
            int num = 255;

            Console.WriteLine("a : {0}", a); // 콘솔에 "a: 255" 라고 출력됨
            Console.WriteLine("b : " + b); // 콘솔에 "b: 255" 라고 출력됨
            Console.WriteLine("num : " + num); // 콘솔에 "num: 255" 라고 출력됨
        }
    }
}
