using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _009_Data2
 * DESC : 정수 데이터형의 최소 최대값..
--------------------------------------------------------------------------- */

namespace _009_Data2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 자료형.MinValue, MaxValue를 통해 최소값, 최대값을 알 수 있다.
            Console.WriteLine("short min : {0} ~ short max : {1}", short.MinValue, short.MaxValue); // 콘솔에 "short min : -32768 ~short max: 32767" 라고 출력됨
            Console.WriteLine("byte min : {0} ~ byte max : {1}", byte.MinValue, byte.MaxValue); // 콘솔에 "byte min : 0 ~byte max: 255" 라고 출력됨
            Console.WriteLine("int min : {0} ~ int max : {1}", int.MinValue, int.MaxValue); // 콘솔에 "int min : -2147483648 ~int max: 2147483647" 라고 출력됨
            Console.WriteLine("long min : {0} ~ long max : {1}", long.MinValue, long.MaxValue); // 콘솔에 "long min : -9223372036854775808 ~ long max : 9223372036854775807" 라고 출력됨
        }
    }
}
