using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _029_Data_Reference
 * DESC : boxing, unboxing기초(boxing하는 과정에서 heap 영역에 메모리가 할당)
--------------------------------------------------------------------------- */

namespace _029_Data_boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i; // boxing
            int j = (int)o; // unboxing
            i = 456;

            Console.WriteLine("i : {0}, o : {1}, j : {2}", i, o, j); // 콘솔에 "i: 456, o: 123, j: 123"라고 출력됨
            Console.WriteLine("ReferenceEquals : {0}", Object.ReferenceEquals(i, o)); // 콘솔에 "ReferenceEquals: False"라고 출력됨
        }
    }
}