using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _030_ReadLine
 * DESC : ReadLine의 기초(입력한 문자열을 받아줌)
--------------------------------------------------------------------------- */

namespace _030_ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요. "); // 콘솔에 "정수를 입력하세요"라고 출력됨
            string inputNum = Console.ReadLine(); // 입력한 줄의 문자열을 받아줌.
            int num = int.Parse(inputNum); // 받은 문자열을 int형으로 형변환 시켜 저장시킴

            Console.WriteLine("입력한 수는 : " + num); // 저장한 값 출력
        }
    }
}
