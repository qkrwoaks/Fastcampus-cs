using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _026_Data_Parse
 * DESC : Parse 기초(스트링 -> 정수, 실수 자료형 변환)
--------------------------------------------------------------------------- */

namespace _026_Data_Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strA = "100";
            string strB = "3.14135";
            string strC = "3.141415135125141212421132";

            int parseA = int.Parse(strA); // strA를 int형으로 형변환
            float parseB = float.Parse(strB); // strB를 float형으로 형변환
            decimal parseC = decimal.Parse(strC); // strC는 decimal형으로 형변환

            Console.WriteLine("int.Parse : {0}", strA); // 콘솔에 "int.Parse : 100"라고 출력됨
            Console.WriteLine("float.Parse : {0}", strB); // 콘솔에 "float.Parse : 3.14135"라고 출력됨
            Console.WriteLine("decimal.Parse : {0}", strC); // 콘솔에 "decimal.Parse : 3.141415135125141212421132"라고 출력됨
        }
    }
}