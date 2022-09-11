using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();

            //list.Add("문자열");
            //list.Add(100);
            //list.Add(true);

            //list.Insert(2, 200);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            // ------------------------------------

            //int n = 100;

            //object o = n;

            //int b = (int)o;

            // ------------------------------------

            //List<string> list = new List<string>();

            //list.Add("슬램덩크");
            //list.Add("드래곤볼");
            //list.Add("나루토");

            //list.Insert(0, "데스노트");
            //list.RemoveAt(2);
            //list.Remove("나루토");

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            // ------------------------------------

            List<int> list = new List<int>();

            list.Add(5);
            list.Add(3);
            list.Add(10);
            list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
