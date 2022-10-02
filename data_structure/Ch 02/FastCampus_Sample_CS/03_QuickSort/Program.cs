using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 퀵정렬(Quick Sort) 이란 ?
// 퀵정렬은 피봇을 기준으로 작거나 같은 값을 지닌 데이터는 앞으로, 큰 값을 지닌 데이터는 뒤로 가도록 하여 작은 값을 갖는 데이터와 큰 값을 갖는 데이터로 분리해가며 정렬하는 방법

// 종류
// 1. 분할 정복 알고리즘 2. 일반적으로 빠른 알고리즘

namespace _03_QuickSort
{
    internal class Program
    {
        static int[] data = { 25, 15, 60, 45, 10, 20, 5, 30 }; // 정렬할 데이터 값

        static void Main(string[] args)
        {
            Console.WriteLine("퀵정렬");

            Console.Write("시작 값 : ");

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i].ToString() + ", ");
            }

            Console.WriteLine();

            SortQuick(0, data.Length - 1);

            Console.Write("정렬값 : ");

            // 데이터 값 출력
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i].ToString() + ", ");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// 퀵정렬 함수
        /// </summary>
        /// <param name="nFirst">첫번째 값</param>
        /// <param name="nLast">마지막 값</param>
        static void SortQuick(int nFirst, int nLast)
        {
            if (nFirst < nLast)
            {
                int pivotIndex = FuncPartition(nFirst, nLast);
                
                // 분할 정복(재귀 사용)
                SortQuick(nFirst, pivotIndex - 1);
                SortQuick(pivotIndex + 1, nLast);
            }
        }

        /// <summary>
        /// 함수 부분화
        /// </summary>
        /// <param name="nFirst">첫번째 값</param>
        /// <param name="nLast">마지막 값</param>
        /// <returns></returns>
        static int FuncPartition(int nFirst, int nLast)
        {
            int nLow, nHigh, nPivot;

            // 임의 값 여기에서는 마지막 값
            nPivot = data[nLast];

            nLow = nFirst;
            nHigh = nLast - 1;

            while (nLow <= nHigh)
            {
                while (data[nLow] < nPivot)
                {
                    nLow++;
                }

                while (data[nHigh] > nPivot)
                {
                    nHigh--;
                }

                if (nLow <= nHigh)
                {
                    Swap(data, nLow, nHigh);
                }
            }

            Swap(data, nLow, nLast);

            return nLow;
        }

        /// <summary>
        /// 두 변수의 값을 바꾸는 함수
        /// </summary>
        /// <param name="nArrData">바꿀 </param>
        /// <param name="nValue1"></param>
        /// <param name="nValue2"></param>
        static void Swap(int[] nArrData, int nValue1, int nValue2)
        {
            int nTemp = nArrData[nValue1];
            nArrData[nValue1] = nArrData[nValue2];
            nArrData[nValue2] = nTemp;
        }
    }
}
