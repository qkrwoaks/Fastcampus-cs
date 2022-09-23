using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06_Hashtable_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashtable & Dictionary");

            Hashtable hash = new Hashtable();

            hash.Add(0, "정현");
            hash.Add(1, "패스트캠프");
            hash.Add(2, "C#");
            hash.Add(3, "자료구조");

            Console.WriteLine(hash[1]);

            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("정현", "010-0000-0001");
            dic.Add("패캠", "010-0000-0002");
            dic.Add("C#", "010-0000-0003");

            foreach (var item in dic.Keys)
            {
                Console.WriteLine(item + " : " + dic[item]);
            }
            
            if (!dic.ContainsKey("용희"))
            {
                dic.Add("용희", "010-2222-3333");
            }

            foreach (var item in dic.Keys)
            {
                Console.WriteLine(item + " : " + dic[item]);
            }
        }
    }
}
