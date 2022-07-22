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
            const string LINE = "---------------------------------------------";
            const int END_Line = 42;
            const int DELAY_TIME = 100;

            int runA = 0;
            int runB = 0;
            int runC = 0;
            int runD = 0;

            while (true)
            {
                Thread.Sleep(DELAY_TIME); // 지정된 시간 만큼 스레드를 일시 중단 하는 함수 (딜레이)
                Console.Clear(); // 콘솔 버퍼, 창에 표시 정보를 지우는 함수 (화면 지우기)

                runA++;
                runB++;
                runC++;
                runD++;

                int randomNumber = random.Next(0, 4); // 0 ~ 3
                int runRandomNumber = random.Next(0, 2); // 0 ~ 1

                switch (randomNumber)
                {
                    case 0:
                        runA += runRandomNumber;
                        break;
                    case 1:
                        runB += runRandomNumber;
                        break;
                    case 2:
                        runC += runRandomNumber;
                        break;
                    case 3:
                        runD += runRandomNumber;
                        break;
                }

                Console.WriteLine(LINE);
                for (int i = 0; i < runA; i++)
                    Console.Write(" ");
                Console.Write("1");

                for (int i = (END_Line) - runA; i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runB; i++)
                    Console.Write(" ");
                Console.Write("2");

                for (int i = (END_Line) - runB; i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runC; i++)
                    Console.Write(" ");
                Console.Write("3");

                for (int i = (END_Line) - runC; i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runD; i++)
                    Console.Write(" ");
                Console.Write("4");

                for (int i = (END_Line) - runD; i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                Console.WriteLine(LINE);

                if (runA >= END_Line || runB >= END_Line || runC >= END_Line || runD >= END_Line)
                {
                    int runNum = 0;
                    string stringResult = "결과 : !! {0} 선수 우승 !!";

                    if (runA >= END_Line)
                        runNum = 1;
                    else if (runB >= END_Line)
                        runNum = 2;
                    else if (runC >= END_Line)
                        runNum = 3;
                    else if (runD >= END_Line)
                        runNum = 4;

                    Console.WriteLine(stringResult, runNum);

                    Console.Write("다시하려면 0번 입력 : ");
                    if (Console.ReadLine() == "0")
                    {
                        runA = 0;
                        runB = 0;
                        runC = 0;
                        runD = 0;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
