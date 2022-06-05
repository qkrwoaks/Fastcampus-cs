using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _022_Data_var
 * DESC : var데이터형 활용
--------------------------------------------------------------------------- */

namespace _022_Data_var
{
    class Program
    {
        // 불가 : 반드시 지역변수만 사용
        // var globalVar = 100;

        static void Main(string[] args)
        {
            var a = 100;
            var b = 3.14324135235326243254364634643f;
            var c = 3.14324135235326243254364634643m;
            var d = 'H';
            var e = 'i';
            var f = "World!!";
            var g = false;

            Console.WriteLine("type : {0}, a : {1}", a.GetType(), a); // 콘솔에 "type: System.Int32, a: 100"라고 출력됨
            Console.WriteLine("type : {0}, b : {1}", b.GetType(), b); // 콘솔에 "type: System.Single, b: 3.143241"라고 출력됨
            Console.WriteLine("type : {0}, c : {1}", c.GetType(), c); // 콘솔에 "type: System.Decimal, c: 3.1432413523532624325436463464"라고 출력됨
            Console.WriteLine("type : {0}, g : {1}", g.GetType(), g); // 콘솔에 "type: System.Boolean, g: False"라고 출력됨

            Console.WriteLine("{0}{1} {2}", d, e, f); // 콘솔에 "Hi World!!"라고 출력됨

            // 불가 : 반드시 선언과 동시에 초기화
            // var noInitialVar;

            var num = 0;
            num = 100;

            Console.WriteLine("num : " + num); // 콘솔에 "num : 100"라고 출력됨
        }
    }
}