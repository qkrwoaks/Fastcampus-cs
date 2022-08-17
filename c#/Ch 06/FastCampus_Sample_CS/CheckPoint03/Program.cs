using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/// <summary>
/// CheckPoint03 - 배열을 활용하기
/// </summary>
namespace CheckPoint03
{
    internal class Program
    {
        const int MAP_X = 7;
        const int MAP_Y = 22;
        const int DELAY_TIME = 300;

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

        static void ClearView()
        {
            Thread.Sleep(DELAY_TIME);
            Console.Clear();
        }

        static void UpdateGO(int[] _arrIndexX, int[,] _map)
        {
            for (int i = 0; i < _arrIndexX.Length; i++)
            {
                int indexMapX = i + 1;
                int indexY = _arrIndexX[i];

                int temp = _map[indexMapX, _arrIndexX[i]];
                _map[indexMapX, _arrIndexX[i + 1]] = temp;
                _map[indexMapX, _arrIndexX[i]] = 0;

                if (_arrIndexX[i] < 19)
                    _arrIndexX[i]++;
            }
        }

        static bool UpdateRandomGO(int[] _arrIndexX, int[,] _map, Random _random)
        {
            bool isFinish = false;

            for (int i = 0; i < _arrIndexX.Length; i++)
            {
                if (_arrIndexX[i] >= 20)
                {
                    isFinish = true;
                    break;
                }
            }

            int randomIndex = _random.Next(0, 5);

            int indexY = _arrIndexX[randomIndex];

            int temp = _map[randomIndex + 1, indexY];
            _map[randomIndex + 1, indexY + 1] = temp;
            _map[randomIndex + 1, indexY] = 0;

            _arrIndexX[randomIndex]++;

            return isFinish;
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            char[] tile = { ' ', '-', '|', '1', '2', '3', '4', '5' };

            int[,] map = new int[MAP_X, MAP_Y]
            {
                {1, 1, 1, 1, 1, 1, 1,1,1, 1,1, 1, 1, 1, 1, 1, 1,1,1, 1,1,1},
                {3, 0, 0, 0, 0, 0, 0,0,0, 0,0, 0, 0, 0, 0, 0, 0,0,0, 0,2,0},
                {4, 0, 0, 0, 0, 0, 0,0,0, 0,0, 0, 0, 0, 0, 0, 0,0,0, 0,2,0},
                {5, 0, 0, 0, 0, 0, 0,0,0, 0,0, 0, 0, 0, 0, 0, 0,0,0, 0,2,0},
                {6, 0, 0, 0, 0, 0, 0,0,0, 0,0, 0, 0, 0, 0, 0, 0,0,0, 0,2,0},
                {7, 0, 0, 0, 0, 0, 0,0,0, 0,0, 0, 0, 0, 0, 0, 0,0,0, 0,2,0},
                {1, 1, 1, 1, 1, 1, 1,1,1, 1,1, 1, 1, 1, 1, 1, 1,1,1, 1,1,1}
            };

            int[] arrIndexX = { 0, 0, 0, 0, 0 };
            bool isFinish = false;

            while (true)
            {
                if (isFinish)
                {
                    Console.WriteLine();
                    for (int i = 0; i < arrIndexX.Length; i++)
                    {
                        if (arrIndexX[i] >= 19)
                        {
                            Console.Write("달리기 결과=> 1등 : ", (i + 1));

                        }
                    }
                    Console.Write("\n다시 시작하려면 0을 입력");
                    string inputSr = Console.ReadLine();

                    if (inputSr == "0")
                    {

                    }
                    else
                    {
                        Console.Write("\n나가기");
                        break;
                    }
                }

                ClearView();
            }
        }
    }
}
