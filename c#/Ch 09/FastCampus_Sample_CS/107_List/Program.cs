using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _107_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listAA = new List<int>();
            listAA.Add(1);
            listAA.Add(2);

            for (int i = 0; i < 10; i++)
            {
                listAA.Add(i);
            }

            foreach (var data in listAA)
            {
                Console.WriteLine("data : " + data);
            }

            Console.WriteLine("\n배열데이터로 초기화");
            string[] arrData = { "AA", "BB", "CC" };
            List<string> listArr = new List<string>(arrData);

            for (int i = 0; i < arrData.Length; i++)
            {
                Console.WriteLine("arrData : " + arrData[i]);
            }
        }
    }
}
