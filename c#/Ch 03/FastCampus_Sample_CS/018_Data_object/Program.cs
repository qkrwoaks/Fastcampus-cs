using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _018_Data_object
 * DESC : object데이터형 기초
--------------------------------------------------------------------------- */

namespace _018_Data_object
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = 100;
            object b = 3.14123911231251352346463f;
            object c = 3.14123911231251352346463m;
            object d = 'H';
            object e = 'i';
            object f = "World!!";
            object g = false;

            Console.WriteLine("a : {0}", a); // 콘솔에 "a : 100"라고 출력됨
            Console.WriteLine("b : {0}", b); // 콘솔에 "b : 3.141239"라고 출력됨
            Console.WriteLine("c : {0}", c); // 콘솔에 "c : 3.14123911231251352346463"라고 출력됨
            Console.WriteLine("{0}{1} {2}", d, e, f); // 콘솔에 "Hi World!!"라고 출력됨
            Console.WriteLine("g : {0}", g); // 콘솔에 "g : False"라고 출력됨
        }
    }
}
