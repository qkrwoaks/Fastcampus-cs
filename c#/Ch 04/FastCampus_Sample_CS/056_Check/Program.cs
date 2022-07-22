using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            int count = 0;
            int answer;

            Random random = new Random();

            while (true)
            {
                answer = random.Next(99);
                while (true)
                {
                    count++;
                    Console.WriteLine("0~99 사이 어떤 숫자일까요 (단, 0은 나가기)");
                    input = int.Parse(Console.ReadLine());
                    if (input == answer)
                    {
                        Console.WriteLine("=== 정답 입니다.===");
                        Console.WriteLine("총 {0}번 시도", count);
                        break;
                    }
                    else if (input == 0)
                    {
                        Console.WriteLine("종료 합니다.");
                        break;
                    }
                    else if (input < answer)
                    {
                        Console.WriteLine("입력한 수보다는 커요");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("입력한 수보다는 작아요");
                        continue;
                    }
                }
                Console.WriteLine("계속하려면 아무 키나 누르십시오 . . .  (단, 0은 나가기)");
                input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    Console.WriteLine("종료합니다.");
                    break;
                }
            }
        }
    }
}
