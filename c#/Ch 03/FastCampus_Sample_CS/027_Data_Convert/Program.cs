using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _027_Data_Convert
 * DESC : Convert 기초, ToString, Parse 
--------------------------------------------------------------------------- */

namespace _027_Data_Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            float b = 3.141593f;
            decimal c = 3.141241212412515121m;

            string strA = a.ToString(); // int a를 string형으로 변환 
            string strB = b.ToString(); // float b를 string형으로 변환 
            string strC = c.ToString(); // decimal c를 string형으로 변환 

            Console.WriteLine("a.ToString() : {0}", strA); // 콘솔에 "a.ToString() : 100"라고 출력됨
            Console.WriteLine("b.ToString() : {0}", strB); // 콘솔에 "b.ToString() : 3.141593"라고 출력됨
            Console.WriteLine("c.ToString() : {0}", strC); // 콘솔에 "c.ToString() : 3.141241212412515121"라고 출력됨
            Console.WriteLine();

            int parseA = int.Parse(strA); // string strA를 int형으로 형변환 
            float parseB = float.Parse(strB); // string strB를 float형으로 형변환
            decimal parseC = decimal.Parse(strC); // string strC는 decimal형으로 형변환

            Console.WriteLine("int.Parse : {0}", strA); // 콘솔에 "int.Parse : 100"라고 출력됨
            Console.WriteLine("float.Parse : {0}", strB); // 콘솔에 "float.Parse : 3.14135"라고 출력됨
            Console.WriteLine("decimal.Parse : {0}", strC); // 콘솔에 "decimal.Parse : 3.141415135125141212421132"라고 출력됨
            Console.WriteLine();

            int convertA = Convert.ToInt32(strA); // string strA를 int형으로 형변환
            float convertB = Convert.ToSingle(strB); // string strB를 float형으로 형변환
            decimal convertC = Convert.ToDecimal(strC); // string strC를 decimal형으로 형변환 

            Console.WriteLine("Convert.ToInt(strA) : {0}", strA);
            Console.WriteLine("Convert.ToSingle(strB) : {0}", strB);
            Console.WriteLine("Convert.ToDecimal(strC) : {0}", strC);
        }
    }
}

// Convert와 Parse의 차이점
// 값에 오류가 발생하면 Convert의 경우 0을 반환, Parse의 경우 ArgumentNullException를 반환한다.