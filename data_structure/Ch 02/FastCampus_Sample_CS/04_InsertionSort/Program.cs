using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 삽입정렬(Insertion Sort) 이란?
// 삽입정렬은 앞의 숫자가 나보다 큰지 비교하면서 자신의 위치에 삽입하는 정렬

// 특징
// 앞의 값과 비교를 하기 때문에 전체 배열 중 0번 인덱스가 아닌 1번 인덱스부터 앞의 값과 비교

namespace _04_InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("삽입정렬");

            int[] nArrData = { 20, 15, 1, 5, 10 }; // 정렬할 데이터 값

            // 정렬 시작
            for (int i = 1; i < nArrData.Length; i++)
            {
                int key = i;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (nArrData[key] < nArrData[j]) // 현재 변수값이 보다 이전 변수값이 클 때
                    {
                        // Swap
                        int nTemp = nArrData[j];
                        nArrData[j] = nArrData[key];  
                        nArrData[key] = nTemp;
                        key = j;
                    }
                    else
                    {
                        break;
                    }
                }

                // 변경된 값 출력
                for (int j = 0; j < nArrData.Length; j++)
                {
                    Console.Write(nArrData[j] + ", ");
                }

                Console.WriteLine();
            }
        }
    }
}
