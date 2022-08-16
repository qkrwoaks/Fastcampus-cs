﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// CheckPoint03 - 배열을 활용하기
/// </summary>
namespace CheckPoint03
{
    internal class Program
    {
        const int MAP_X = 7;
        const int MAP_Y = 22;

        static void UpdateView(char[] _tile, int[,] _map)
        {
            for (int i = 0; i < MAP_X; i++)
            {
                for (int j = 0; j < MAP_Y; j++)
                {
                    int tileIndex = _map[i, j];
                    Console.Write(_tile[tileIndex]);

                    if (j == MAP_Y - 1)
                        Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {

            char[] tile = { ' ', '-', '|', '1', '2', '3', '4', '5' };

            int[,] map = new int[7, 22]
            {
                {1, 1, 1, 1, 1, 1, 1,1,1, 1,1, 1, 1, 1, 1, 1, 1,1,1, 1,1,1},
                {3, 0, 0, 0, 0, 0, 0,0,0, 0,0, 0, 0, 0, 0, 0, 0,0,0, 0,0,0},
                {4, 0, 0, 0, 0, 0, 0,0,0, 0,0, 0, 0, 0, 0, 0, 0,0,0, 0,0,0},
                {5, 0, 0, 0, 0, 0, 0,0,0, 0,0, 0, 0, 0, 0, 0, 0,0,0, 0,0,0},
                {6, 0, 0, 0, 0, 0, 0,0,0, 0,0, 0, 0, 0, 0, 0, 0,0,0, 0,0,0},
                {7, 0, 0, 0, 0, 0, 0,0,0, 0,0, 0, 0, 0, 0, 0, 0,0,0, 0,0,0},
                {1, 1, 1, 1, 1, 1, 1,1,1, 1,1, 1, 1, 1, 1, 1, 1,1,1, 1,1,1}
            };

            UpdateView(tile, map);
        }
    }
}
