using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _04_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1); // 1
            stack.Push(2); // 1, 2
            stack.Pop(); // 1
            stack.Push(3); // 1, 3
            stack.Push(4); // 1, 3, 4
            stack.Peek(); // 1, 3, 4
            stack.Push(5); // 1, 3, 4, 5
            
            Console.WriteLine("스택의 갯수 : " + stack.Count);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            // 제네릭 타입이 아닌 Stack
            // Stack stack1 = new Stack();
            // stack1.Push("문자열");
            // stack1.Push(1);
            // stack1.Push(true);

            // while (stack1.Count > 0)
            //      Console.WriteLine(stack1 Pop());

            // stack1.Push("ArrayStack");



            //ArrayStack arrayStack = new ArrayStack(5);

            //arrayStack.Push(1);
            //arrayStack.Push(2);
            //arrayStack.Push(3);
            //arrayStack.Push(4);
            //arrayStack.Push(5);

            //while (arrayStack.Count > 0)
            //{
            //    Console.WriteLine(arrayStack.Pop());
            //}
        }
    }
}
