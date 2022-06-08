using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _028_Data_Reference
 * DESC : Reference참조 기초(두 개의 값이 서로 영향을 준다)
--------------------------------------------------------------------------- */

namespace _028_Data_Reference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            int refNum = num;
            refNum = 1000;

            Console.WriteLine("refStr : {0}     ReferenceEquals : {1}", num, Object.ReferenceEquals(num, refNum)); // 콘솔에 "refStr: 100     ReferenceEquals: False"라고 출력됨

            int[] arrNum = { 100, 200 };
            int[] refArrNum = arrNum;
            refArrNum[0] = 1000;

            Console.WriteLine("refStr : {0}     ReferenceEquals : {1}", num, Object.ReferenceEquals(arrNum, refArrNum)); // 콘솔에 "refStr : 100     ReferenceEquals: True"라고 출력됨
        }
    }
}

// 참조형(reference)
// 배열, string, class, interface, delegate
// 두개의 변수가 서로 영향을 줌 (스택 영역 변수, 힙 영역 변수)
// 값을 저장하는 것이 아닌 주소를 참조
