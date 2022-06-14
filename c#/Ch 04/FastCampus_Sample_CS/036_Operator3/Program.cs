using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _036_Operator3
 * DESC : '++', '--' 증감 연산자에 대해 알아봄
--------------------------------------------------------------------------- */

namespace _036_Operator3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            Console.WriteLine("num : " + num++);
            Console.WriteLine("num : " + num);
            Console.WriteLine("num : " + ++num);

            Console.WriteLine("num : " + num--);
            Console.WriteLine("num : " + num);
            Console.WriteLine("num : " + --num);
        }
    }
}