using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _054_Operator_goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    goto AA; // goto는 뒤에 오는 예약어에 따라 특정 위치로 이동하는 함수
                }

                if (i == 7)
                {
                    goto BB;
                }
            }

        AA:
            Console.WriteLine("goto AA");
        BB:
            Console.WriteLine("goto BB");
        }
    }
}
