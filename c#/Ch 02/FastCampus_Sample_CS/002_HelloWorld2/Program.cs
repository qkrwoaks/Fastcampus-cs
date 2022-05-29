using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _001_HelloWorld
 * DESC : 메인 함수의 파라미터 보기
--------------------------------------------------------------------------- */

namespace _002_HelloWorld2
{
    class Program
    {
        // Main의 args에 값을 넣는 방법
        // cmd 창을 열어 cd..을 입력한다.
        // "cd"+ 파일 위치를 입력한다.
        static void Main(string[] args)
        {
            if (args.Length > 0) // 입력받은 문자열이 0보다 클때(존재)
            {
                Console.WriteLine("HelloWorld:  " + args[0]);
                // 콘솔 창에 "HelloWorld: args.Length = 0"라고 나타난다.
                // 줄바꿈이 일어난다.
            }
            else
            {
                Console.WriteLine("HelloWorld: args.Length = 0");
            }

            Console.ReadKey(); // 콘솔창에서 Key값을 입력 받는다.
        }
    }
}
