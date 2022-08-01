using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*------------------------------------------------
  * Name : 066_Func_params
  * Desc : 파라미터 제한 없이 처리
------------------------------------------------ */
namespace _066_Func_Params
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        static int Total(params int[] values)
        {
            int total = 0;
            for (int i = 0; i < values.Length; i++)
            {
                total += values[i];
            }
            return total;
        }

        /// <summary>
        /// 값의 타입을 확인하여 콘솔에 출력하는 함수
        /// </summary>
        /// <param name="values">확인 해야하는 값</param>ㄴ
        static void CheckValues(params object[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("Value : {0}  {1}", values[i], values[i].GetType()); // .GetType : System에 정의되어 있는 타입을 가져오는 함수
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Total : " + Total(200, 5, 3, 1, 100));
            Console.WriteLine("Total : " + Total(1, 2, 3, 4, 5));
            Console.WriteLine("Total : " + Total(10, 1000));

            CheckValues(0, 10.2f, 10.4, 11312410d, "Hello World");
        }
    }
}
