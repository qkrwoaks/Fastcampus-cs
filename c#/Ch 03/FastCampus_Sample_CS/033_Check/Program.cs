using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _033_Check
 * DESC : 국어, 영어, 수학, 과학 4과목을 입력받고, 총점과 평균 보여주기
--------------------------------------------------------------------------- */

/* 출력하기
    국어 점수 입력하세요... 75
    영어 점수 입력하세요... 80
    수학 점수 입력하세요... 45
    과학 점수 입력하세요... 90
    국어 : 75    영어 : 80    수학 : 45    과학 : 90
    총점 : 290, 평균 : 72.5
*/

namespace _033_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[4];
            string[] subject = { "국어", "영어", "수학", "과학" };
            float sum = 0;

            for (int i = 0; i < subject.Length; i++)
            {
                Console.Write(subject[i] + " 점수 입력하세요... ");
                score[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < score.Length; i++) sum += score[i];
            for (int i = 0; i < subject.Length; i++) Console.Write(subject[i] + " : " + score[i] + "    ");
            Console.WriteLine("\n총점 : {0}, 평균 : {1}", sum, sum / score.Length);

        }
    }
}
