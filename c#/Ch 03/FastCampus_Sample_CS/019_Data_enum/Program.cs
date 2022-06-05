using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _019_Data_enum
 * DESC : enum데이터형 기초
--------------------------------------------------------------------------- */

namespace _019_Data_enum
{
    class Program
    {
        enum DAY_OF_WEEK
        {
            SUN, // 0
            MON, // 1
            THE, // 2
            WED, // 3
            THU, // 4
            FRI, // 5
            SAT, // 6
        }


        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.SUN, (int)DAY_OF_WEEK.SUN); // 콘솔에 "SUN 0"라고 출력됨
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.MON, (int)DAY_OF_WEEK.MON); // 콘솔에 "MON 1"라고 출력됨
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.THE, (int)DAY_OF_WEEK.THE); // 콘솔에 "THE 2"라고 출력됨
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.WED, (int)DAY_OF_WEEK.WED); // 콘솔에 "WED 3"라고 출력됨
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.THU, (int)DAY_OF_WEEK.THU); // 콘솔에 "THU 4"라고 출력됨
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.FRI, (int)DAY_OF_WEEK.FRI); // 콘솔에 "FRI 5"라고 출력됨
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.SAT, (int)DAY_OF_WEEK.SAT); // 콘솔에 "SAT 6"라고 출력됨
        }
    }
}
