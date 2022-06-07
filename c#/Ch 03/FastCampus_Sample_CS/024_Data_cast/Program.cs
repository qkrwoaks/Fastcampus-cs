using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _024_Data_const
 * DESC : cast연산자(   ) 기초
--------------------------------------------------------------------------- */

namespace _024_Data_cast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            double dNum = (double)num; // cast연산자를 사용한 형변환
            Console.WriteLine("num : {0}, dNum : {1}", num, dNum); // 콘솔에 "num: 100, dNum: 100"라고 출력됨

            double dNum2 = 123456789012;
            int num2 = (int)dNum2; // 큰데이터형을 작은 데이터형으로 변경시 주의 (값 초과시 에러값 출력)
            Console.WriteLine("dNum2 : {0}, num2 : {1}", dNum2, num2); // 콘솔에 "dNum2: 1234567890, num2: 1234567890"라고 출력됨
        }
    }
}