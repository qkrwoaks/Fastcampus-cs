using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _062_FuncSwap
{
    internal class Program
    {
        /// <summary>
        /// 값을 바꾸는 함수
        /// </summary>
        /// <param name="a">첫번째 변수</param>
        /// <param name="b">두번째 변수</param>
        static public void ValueSwap(int a, int b)
        {
            int temp = a; // 두 변수의 값을 바꿀때 사용할 임시 변수
            a = b;
            b = temp;

            Console.WriteLine("ValueSwap");
            Console.WriteLine("a : {0} , b : {1}", a, b);
        }

        static public void RefSwap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("RefSwap");
            Console.WriteLine("a : {0}, b : {1}", a, b);
        }

        static void Main(string[] args)
        {
            int a = 100;
            int b = -100;

            ValueSwap(a, b); // 자료형의 값 변경 (출력시 바뀜)
            Console.WriteLine("a : {0}, b : {1}", a, b);

            RefSwap(ref a, ref b); // 자료형의 주소 변경 (출력시 바뀌지 않음)
            Console.WriteLine("a : {0}, b : {1}", a, b);
        }
    }
}
// Call By Value - 값에 의한 호출 / 함수에서 값에 영향을 주지 않는다 / 일반함수
// Call By Reference - 주소에 의한 호출 / 함수에서 값에 영향을 준다 / ref 키워드를 가지는 함수