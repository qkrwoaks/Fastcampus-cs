using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LinkedList
{
    internal class SinglyLinkedList<T>
    {
        private Node<T> m_head;

        public void AddLast(T data)
        {
            Node<T> node = new Node<T>(data);

            if (m_head == null)
            {
                m_head = node;
            }
            else
            {
                Node<T> last = m_head;

                while (last.Next != null)
                {
                    last = last.Next;
                }

                last.Next = node;
            }
        }

        internal void AddFirst(T value)
        {
            Node<T> node = new Node<T>(value);

            node.Next = m_head;

            m_head = node;
        }

        public override string ToString()
        {
            var temp = m_head;
            string data = "";

            while (temp != null)
            {
                if (!string.IsNullOrEmpty(data))
                    data += ",";
                data += temp.Data.ToString();

                temp = temp.Next;
            }

            return data;
        }
    }
}
