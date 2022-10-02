using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 버블정렬(Bubble Sort) 이란? 
// 버블정렬은 서로 이웃한 데이터들을 비교하며 가장 큰 데이터를 가장 뒤로 보내는 정렬방식

// 방법
// 1. 첫번째 데이터와 두번째 데이터를 비교하여 첫번째 값이 더 크면 두번째 데이터와 교환한다. 2. 두번째 데이터와 세번째 데이터를 비교하여 더 큰 수를 뒤로 보낸다. 3. 이렇게 끝까지 진행하면, 제일 큰 숫자가 맨 뒤로 가게된다. 이렇게 계속 처음부터 n - 1 번째 데이터를 비교해서 정렬하는 알고리즘이다.

// 특징 
// 1. 구현은 단순하지만 비교적 성능이 좋지 않음. 2. 배열의 모든 요소와 교환 해야한다. 3. 이미 정렬이 된 데이터도 교환되는 일이 발생된다.
namespace _02_BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nArrData = { 20, 15, 1, 5, 10 }; // 정렬할 데이터 값

            Console.WriteLine("버블정렬");

            Console.Write("시작 값 : ");

            // 데이터 값 출력
            for (int i = 0; i < nArrData.Length; i++)
            {
                Console.Write(nArrData[i].ToString() + ",");
            }

            Console.WriteLine();

            // 정렬 시작
            for (int i = 0; i < nArrData.Length; i++)
            {
                for (int j = 0; j < nArrData.Length - 1 - i; j++)
                {
                    if (nArrData[j] > nArrData[j + 1]) // 현재 변수값이 다음 변수값보다 클 때
                    {
                        Swap(ref nArrData[j], ref nArrData[j + 1]); // 현재 변수의 참조값과, 가장 작은 변수의 참조값 변경                    }

                        Console.Write((i + 1) + "번째 정렬값(" + j + ", " + (j + 1) + ") : "); // 변경된 값 출력

                        for (int k = 0; k < nArrData.Length; k++) // 최종 정렬된 값 출력
                        {
                            Console.Write(nArrData[k].ToString() + ",");
                        }

                        Console.WriteLine();
                    }
                }
            }
        }

        /// <summary>
        /// 두 변수의 참조값을 바꿔주는 함수 
        /// </summary>
        /// <param name="a">첫번째 변수의 참조값</param>
        /// <param name="b">두번째 변수의 참조값</param>
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }
    }
}
