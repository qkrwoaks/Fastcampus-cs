using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lotto test = new Lotto();   
        }

        class Lotto
        {
            private int[] number;

            public Lotto()
            {
                GetNumber();
            }

            private void GetNumber()
            {
                Random random = new Random();
                number = new int[6];

                int index = 0;

                while (index < number.Length)
                {
                    int temp = random.Next(1, 46);

                    if (IsSameNumber(index, temp))
                    {
                        continue;
                    }

                    number[index++] = temp;
                }

                for (int i = 0; i < number.Length; i++)
                {
                    Console.WriteLine(number[i]);
                }
            }

            private bool IsSameNumber(int index, int temp)
            {
                for (int i = 0; i < index; i++)
                {
                    if (number[i] == temp) return true;
                }
                return false;
            }
        }
    }
}
