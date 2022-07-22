using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // 랜덤 클래스 변수 생성
            const int answerLength = 5; // 문제 길이

            int randomValue1; // 첫 번째 랜덤 변수값 
            int randomValue2; // 두 번째 랜덤 변수값

            for (int i = 0; i < answerLength; i++) // 문제의 길이 만큼 반복
            {
                (randomValue1, randomValue2) = (random.Next(100), random.Next(100)); // 0 ~ 99 까지의 랜덤값 두 변수에 대입
                Console.WriteLine(i + ": 다음 두 수의 합은 몇?(총 5문제)\n" + randomValue1 + " + " + randomValue2 + "??"); // 문제 물어보기
                if (int.Parse(Console.ReadLine()) == randomValue1 + randomValue2) // 입력값이 정답인지 확인
                {
                    Console.WriteLine("정답"); // 정답
                }
                else
                {
                    Console.WriteLine("오답(정답은: {0})", randomValue1 + randomValue2); // 실패
                }
            }
        }
    }
}
