using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _013_Data6
 * DESC : 소수점 데이터형의 기초, 리터럴 접미사(f(F), m(M))
--------------------------------------------------------------------------- */

namespace _013_Data6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 3.141592312319273891237891f; // float형 뒤에는 리터럴 접미사(f)를 써야함.
            Console.WriteLine("a : {0}", a); // 콘솔에 "a: 3.141592"라고 출력됨.

            double b = 3.141592312319273891237891; // doble형 뒤에는 리터럴 접미사를 쓰지 않음.
            Console.WriteLine("b : {0}", b); // 콘솔에 "b: 3.14159231231927"라고 출력됨.

            decimal c = 3.141592312319273891237891m; // decimal형 뒤에는 리터럴 접미사(m)를 써야함.
            Console.WriteLine("c : {0}", c); // 콘솔에 "c: 3.141592312319273891237891"라고 출력됨.
        }
    }
}
