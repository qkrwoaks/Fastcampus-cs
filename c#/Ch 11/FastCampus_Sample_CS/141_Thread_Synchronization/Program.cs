﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _141_Thread_Synchronization
{
    internal class Program
    {
        static readonly object thisLock = new object();

        static int _index = 0;

        static void RunThread()
        {
            DateTime start = DateTime.Now;
            var sw = Stopwatch.StartNew();

            // 크리티컬 섹션
            // lock 블록이 끝나기 전까지 다른 쓰레드는 이 코드를 실행 x
            // lock (thisLock)
            {
                _index++;

                Console.WriteLine(string.Format("RunThread Start"));

                Console.WriteLine("RunThread sec : {0:N2}", sw.ElapsedMilliseconds / 1000.0f);
                Thread.Sleep(100);

                Console.WriteLine(string.Format("RunThreadEnd"));
                Console.WriteLine("_index : " + _index);
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread aa = new Thread(new ThreadStart(RunThread));
                aa.Start();
            }
        }
    }
}
