using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _010_Data3
 * DESC : 데이터 형태 오류
--------------------------------------------------------------------------- */

namespace _010_Data3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 데이터 형식의 오류
            byte sbyteData = 255;
            sbyte sbyteData2 = (sbyte)sbyteData; // 캐스트 연산 오류 (큰값 -> 작은값 이동)
            // 캐스트 연산?
            // 캐스트 연산은 변수의 형태를 임시적으로 변환하는 연산이다. (예 : (sbyte)sbyteData)
            int num = (int)sbyteData;

            Console.WriteLine("sbyteData : " + sbyteData); // 콘솔에서 "sbyteData : 255" 라고 출력됨
            Console.WriteLine("sbyteData2 : " + sbyteData2); // 콘솔에서 "sbyteData2 : -1" 라고 출력됨
            Console.WriteLine("sbyte.MaxValue : " + sbyte.MaxValue); // 콘솔에서 "sbyte.MaxValue : 127" 라고 출력됨
            Console.WriteLine("num : " + num); // 콘솔에서 "num : 255" 라고 출력됨
            Console.WriteLine("int.maxValue : " + int.MaxValue); // 콘솔에서 "int.maxValue : 2147483647" 라고 출력됨
        }
    }
}
