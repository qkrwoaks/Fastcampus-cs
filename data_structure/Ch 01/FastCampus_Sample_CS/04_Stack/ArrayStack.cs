using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Stack
{
    internal class ArrayStack
    {
        private int[] m_space; // 전체 공간
        private int m_top;     // 최상단 가르키고 있는 Top
        public int Count 
        { get { return m_space.Length; } }          // 데이터가 몇개 인지

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="size"></param>
        public ArrayStack(int size)
        {
            m_space = new int[size];
            m_top = -1;
        }

        public void Push(int value)
        {
            m_top++;
            m_space[m_top] = value;
        }

        public int Pop()
        {
            int value = m_space[m_top];

            m_space[m_top] = 0;

            m_top--;

            return value;
        }

        public bool IsEmpty()
        {
            return Count != 0;
        }

        public bool IsFull()
        {
            return m_top == m_space.Length - 1;
        }
    }
}
