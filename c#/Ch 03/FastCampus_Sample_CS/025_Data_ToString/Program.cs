using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _025_Data_ToString
 * DESC : ToString 기초
--------------------------------------------------------------------------- */

namespace _025_Data_ToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            float b = 3.141593f;
            decimal c = 3.141241212412515121m;

            string strA = a.ToString(); // a를 string형으로 변환 ("100")
            string strB = b.ToString(); // b를 string형으로 변환 ("3.141593")
            string strC = c.ToString(); // c를 string형으로 변환 ("3.141241212412515121")

            Console.WriteLine("a.ToString() : {0}", strA); // 콘솔에 "a.ToString() : 100"라고 출력됨
            Console.WriteLine("b.ToString() : {0}", strB); // 콘솔에 "b.ToString() : 3.141593"라고 출력됨
            Console.WriteLine("c.ToString() : {0}", strC); // 콘솔에 "c.ToString() : 3.141241212412515121"라고 출력됨
        }
    }
}