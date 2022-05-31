using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*---------------------------------------------------------------------------
 * Name : _012_Data5
 * DESC : 소수점 데이터형의 최소 최대값..
--------------------------------------------------------------------------- */

namespace _012_Data5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("float min  : {0} ~ float max : {1}", float.MinValue, float.MaxValue); // 콘솔에 "float min  : -3.402823E+38 ~float max: 3.402823E+38" 라고 출력됨
            Console.WriteLine("double min  : {0} ~ double max : {1}", double.MinValue, double.MaxValue); // 콘솔에 "double min  : -1.79769313486232E+308 ~double max: 1.79769313486232E+308" 라고 출력됨
            Console.WriteLine("decimal min  : {0} ~ decimal max : {1}", decimal.MinValue, decimal.MaxValue); // 콘솔에 "decimal min  : -79228162514264337593543950335 ~decimal max: 79228162514264337593543950335" 라고 출력됨
            // decimal?
            // 10진수 소수점 데이터형
        }
    }
}
