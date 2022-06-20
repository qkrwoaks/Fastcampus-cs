using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041_Operator_Null

/*---------------------------------------------------------------------------
 * Name : _041_Operator_Null
 * DESC : null 병합 연산자
 * null 병합 연산자 '??'
 * null 값을 체크하는 연산자 "null 인가 ?? 처리1 => true, false"
--------------------------------------------------------------------------- */

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int b = 10;
            int? c = null;
            int d = 100;
            int result;

            result = a ?? b; // 10
            Console.WriteLine(result);

            result = a ?? c ?? d; // 100
            Console.WriteLine(result);
        }
    }
}
