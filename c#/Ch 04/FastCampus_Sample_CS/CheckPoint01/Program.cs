using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CheckPoint01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            const string LINE = "----------------------------------------";
            const int END_Line = 42;

            int runA = 0;
            int runB = 0;
            int runC = 0;
            int runD = 0;

            while (true)
            {
                Thread.Sleep(1000); // 지정된 시간 만큼 스레드를 일시 중단 하는 함수 (딜레이)
                Console.Clear(); // 콘솔 버퍼, 창에 표시 정보를 지우는 함수 (화면 지우기)

                runA++;
                runB++;
                runC++;
                runD++;

                int randomNumber = random.Next(0, 4); // 0 ~ 3

                switch (randomNumber)
                {
                    case 0:
                        ++runA;
                        break;
                    case 1:
                        ++runB;
                        break;
                    case 2:
                        ++runC;
                        break;
                    case 3:
                        ++runD;
                        break;
                }

                Console.WriteLine(LINE);
                for (int i = 0; i < runA; i++)
                    Console.Write(" ");
                Console.WriteLine("1");

                for (int i = 0; i < runA; i++)
                    Console.Write(" ");
                Console.WriteLine("2");

                for (int i = 0; i < runA; i++)
                    Console.Write(" ");
                Console.WriteLine("3");

                for (int i = 0; i < runA; i++)
                    Console.Write(" ");
                Console.WriteLine("4");

                Console.WriteLine(LINE);
            }
        }
    }
}
