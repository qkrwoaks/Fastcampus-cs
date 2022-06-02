using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _016_String
 * DESC : 문자열 제어
--------------------------------------------------------------------------- */

namespace _016_Data9
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abcdefg";
            string str2 = "hijklmn";
            string str3 = str1 + str2; // string 끼리는 "+"를 통해 더 할 수 있음.

            Console.WriteLine("str1 + str2 : {0}", str3);
            // 콘솔에 "str1 + str2 : abcdefghijklmn"라고 출력됨

            string str4 = "zzz";
            string str5 = "zzz";
            Console.WriteLine("str4 == str5 : {0}", (str4 == str5));
            // 콘솔에 "str4 == str5 : True"라고 출력됨

            int x = 10;
            string str6 = str5 + "  " + ":" + x;
            Console.WriteLine("str6 : {0}", str6);
            // 콘솔에 "str6 : zzz  :10"라고 출력됨

            string str7 = "HelloWorld!";
            string str8 = str7.Replace("Hello", "Hi"); // "HelloWorld" 에서 "Hello"부분을 "Hi"로 바꿈
            Console.WriteLine("str8 : {0}", str8);
            // 콘솔에 "str8 : HiWorld!"라고 출력됨

            Console.WriteLine("str8.ToUpper() : {0}", str8.ToUpper()); // 콘솔에 "str8.ToUpper() : HIWORLD!"라고 출력됨
            Console.WriteLine("str8.ToLower() : {0}", str8.ToLower()); // 콘솔에 "str8.ToLower() : hiworld!"라고 출력됨
            // string.ToUpper : 문자열에 포함된 문자를 모두 대문자로 바꿈.
            // string.ToLower : 문자열에 포함된 문자를 모두 소문자로 바꿈.
        }
    }
}
