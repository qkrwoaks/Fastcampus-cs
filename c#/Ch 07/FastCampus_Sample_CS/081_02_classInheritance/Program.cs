using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _081_02_classInheritance
{
    class Sub
    {
        protected int a;

        public Sub()
        {
            a = 100;
            Console.WriteLine(" Call Sub 생성자 호출");
        }

        ~Sub()
        {
            Console.WriteLine(" Call Sub 소멸자 호출");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Sub sub = new Sub();
        }
    }
}
