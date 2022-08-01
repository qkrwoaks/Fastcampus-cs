using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _067_Check
{
    internal class Program
    {
        /// <summary>
        /// 성적 프로그램을 입력하는 함수
        /// </summary>
        static void Start()
        {
            Console.WriteLine("성적 프로그램 - Method");
        }

        /// <summary>
        /// 성적을 입력하는 함수
        /// </summary>
        /// <param name="kor">국어</param>
        /// <param name="mat">수학</param>
        /// <param name="eng">영어</param>
        static void Input(ref int kor, ref int mat, ref int eng)
        {
            Console.WriteLine("국어 성적 입력(정수)? ");
            kor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("수학 성적 입력(정수)? ");
            mat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("영어 성적 입력(정수)? ");
            eng = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// 입력한 성적 값의 합을 구하는 함수
        /// </summary>
        /// <param name="kor">국어</param>
        /// <param name="mat">수학</param>
        /// <param name="eng">영어</param>
        static int Total(int kor, int mat, int eng)
        {
            Console.WriteLine("kor : {0}, mat : {1}, eng : {2}", kor, mat, eng);
            return (kor + mat + eng);
        }

        /// <summary>
        /// 성적의 평균을 구하는 함수
        /// </summary>
        /// <param name="total">성적</param>
        /// <param name="average">평균</param>
        static void Average(int total, out float average)
        {
            average = total / 3f;
        }


        static void Main(string[] args)
        {
            int kor = 0;
            int eng = 0;
            int mat = 0;

            int total;
            float average;

            Start();
            Input(ref kor, ref mat, ref eng);
            total = Total(kor, mat, eng);
            Average(total, out average);

            Console.WriteLine("Total : {0}, Average : {1}", total, average);
        }
    }
}
