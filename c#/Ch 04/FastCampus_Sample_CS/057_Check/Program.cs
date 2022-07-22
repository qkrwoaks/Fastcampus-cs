using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_Check
{
    internal class Program
    {
        static int max = 0;
        static int min = 100;

        static void Main(string[] args)
        {
            int[] testResult = new int[5]; // 성적 결과

            for (int i = 0; i < 5; i++)
            {
                Console.Write("학생의 성적을 입력하세요 : ");
                testResult[i] = int.Parse(Console.ReadLine());
            }
            SetMaxMin(testResult);
            Console.WriteLine("최대값 : {0} 최소값 : {1}", max, min);
        }

        static void SetMaxMin(int[] value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] > max)
                {
                    max = value[i];
                }
                if (value[i] < min)
                {
                    min = value[i];
                }
            }
        }
    }
}
