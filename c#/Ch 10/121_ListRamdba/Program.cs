﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121_ListRamdba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listData = new List<int> { 1, 2, 3, 100, 200, 300 };

            // public delegate bool Predicate<in T>(T obj);
            // public List<T> FindAll(Predicate<T> match);

            List<int> listFindALL = listData.FindAll((num) => { return num < 200; }); // (num) => num < 100

            Console.WriteLine("200보다 작은 모든 수 : ");
            foreach (int a in listFindALL)
            {
                Console.WriteLine("a : " + a);
            }
            
            int findNum = listData.Find((num) => num % 2 == 0);
            Console.WriteLine("첫번째 짝수 : " + findNum);
        }
    }
}
