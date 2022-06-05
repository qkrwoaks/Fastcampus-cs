using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _021_Data_nullable
 * DESC : nullable데이터형 기초
--------------------------------------------------------------------------- */

namespace _021_Data_nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? a = 3.14;
            char? b = 'a';

            int num = 10;
            int? c = num;

            bool? isFlag = null;

            Console.WriteLine("a : {0}", a); // 콘솔에 "a : 3.14"라고 출력됨
            Console.WriteLine("b : {0}", b); // 콘솔에 "b : a"라고 출력됨
            Console.WriteLine("c : {0}", c); // 콘솔에 "c : 10"라고 출력됨

            Console.WriteLine("isFlag : {0}", isFlag); // 콘솔에 "isFlag :"라고 출력됨
            Console.WriteLine("isFlag HasValue : {0}", isFlag.Value); // 콘솔에 라고 출력됨

            if (isFlag.HasValue) // 값을 참조하려면 반드시 null인지 체크..
                Console.WriteLine("isFlag HasValue : {0}", isFlag.Value);
        }
    }
}
