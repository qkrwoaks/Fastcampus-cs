using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

// 힙정렬(Heap Sort) 이란?
// 힙은 완전 이진 트리 구조를 가진 자료 구조이다.
// 이 힙의 특성을 이용하여 정렬을 하는 것

// 특징
// 1. 최소값 혹은 최대값을 빠르게 가져오기 위해 고안됨. 2. 형제 노드 사이에서는 아무런 대소 관계가 정해져 있지 않음.

namespace _05_HeapSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nArrData = { 20, 35, 15, 5, 40, 10, 25, 30 };

            for (int i = (nArrData.Length - 1) / 2; i >= 0; --i)
            {
                CalcHeap(nArrData, i, nArrData.Length);
            }
            for (int i = nArrData.Length - 1; i > 0; --i)
            {
                SwapHeap(ref nArrData[i], ref nArrData[0]); 
                CalcHeap(nArrData, 0, i);
            }

            for (int i = 0; i < nArrData.Length; i++)
            {
                Console.Write(nArrData[i] + ", ");
            }
        }

        static void SwapHeap(ref int nData1, ref int nData2)
        {
            int nTemp = nData1;
            nData1 = nData2;
            nData2 = nTemp;
        }

        static void CalcHeap(int[] nArrData, int nRoot, int nMax)
        {
            while (nRoot < nMax)
            {
                int nChild = nRoot * 2 + 1;
                if (nChild + 1 < nMax && nArrData[nChild] < nArrData[nChild + 1]) ++nChild;
                if (nChild < nMax && nArrData[nRoot] < nArrData[nChild])
                {
                    SwapHeap(ref nArrData[nRoot], ref nArrData[nChild]);
                    nRoot = nChild;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
