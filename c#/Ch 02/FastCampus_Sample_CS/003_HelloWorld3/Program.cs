using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_HelloWorld3
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(" static void Main(string[] args)");
        //    // 콘솔 창에 " static void Main(string[] args)"라고 나타난다

        //}

        //static void Main()
        //{
        //    Console.WriteLine("static void Main");
        //    // 콘솔 창에 "static void Main"라고 나타난다.
        //    // 줄바꿈이 일어난다.
        //}

        //static int Main()
        //{
        //    Console.WriteLine("static int Main");
        //    // 콘솔 창에 "static int Main"라고 나타난다.
        //    // 줄바꿈이 일어난다.
        //    return 0;
        //    // 0을 반환한다.
        //}

        static int Main(string[] args)
        {
            Console.WriteLine("AAA{0} BBB{1}", 1, "ggg");
            // 콘솔 창에 "AAA1 BBBggg"라고 나타난다.
            // 줄바꿈이 일어난다.
            Console.Write("{0}{1}{2}", 1, 2, 3);
            // 콘솔 창에 "1, 2, 3"라고 나타난다.
            Console.WriteLine("static int Main(string[] args)");
            // 콘솔 창에 "static int Main(string[] args)"라고 나타난다.
            return 0;
            // 0을 반환한다.
        }
    }
}
