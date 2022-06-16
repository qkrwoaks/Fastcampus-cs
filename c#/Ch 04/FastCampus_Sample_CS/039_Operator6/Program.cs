using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _039_Operator6
 * DESC : 조건 연산자
 * 삼항 연산자 '? :'
--------------------------------------------------------------------------- */

namespace _039_Operator6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool result;

            result = num == 0 ? true : false; 
            Console.WriteLine(num);
            Console.WriteLine(result);

            result = num > 10 ? true : false; 
            Console.WriteLine(result);    

        }
    }
}
