using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 선택정렬(Selection Sort) 이란?
// 선택정렬은 정렬되지 않은 데이터들에 대해 가장 작은 데이터를 찾아 가장 앞의 데이터와 교환해 나가는 방식

// 방법
// 1. 리스트에서 최소값을 찾는다. 2. 최소값을 맨 앞의 갚과 교체한다. (Swap) 3. 교체한 맨 앞의 데이터는 정렬 된 것으로 간주하고 다음 인덱스부터 1, 2 행위를 끝까지 반복한다.

// 특징
// 1. 구현은 단순하지만 비효율적인 방법 2. 두 개의 for문의 실행 횟수
// Big-O 표기법 (빅오 표기법은 알고리즘의 효율성을 표기해주는 표기법)
// 1. O(1) 2. O(log n) 3. O(n) 4. O(n log n) 5. O(n²)


namespace _01_SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("선택정렬");

            int[] data = { 20, 15, 1, 5, 10 }; // 정렬할 데이터 값

            Console.WriteLine("시작값 - ");

            // 데이터 값 출력
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i] + ", ");
            }

            Console.WriteLine();

            // 정렬 시작
            for (int i = 0; i < data.Length; i++)
            {
                int min = i; // 가장 작은 값의 index 번호

                for (int j = i + 1; j < data.Length; j++) // 가장 작은 값 찾기
                {
                    if (data[min] > data[j])
                        min = j;    
                }

                Swap(ref data[i], ref data[min]); // 현재 변수의 참조값과, 가장 작은 변수의 참조값 변경

                for (int j = 0; j < data.Length; j++) // 변경된 값 출력
                {
                    Console.Write(data[j] + ", ");
                }

                Console.WriteLine();
            }

            Console.Write("정렬 값 - ");

            for (int i = 0; i < data.Length; i++) // 최종 정렬된 값 출력
            {
                Console.Write(data[i] + ", ");
            }

            Console.WriteLine();
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
