using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 종류
// 방향 그래프, 무방향 그래프, 순환 그래프, 비순환 그래프, 가중치 그래프

// 표현
// 인접 리스트, 행렬

namespace _02_ListGraph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("그래프");

            Graph<string> gr = new Graph<string>();
            var v1 = gr.AddVertex("서울");
            var v2 = gr.AddVertex("프랑스");
            var v3 = gr.AddVertex("미국");
            var v4 = gr.AddVertex("방콕");

            gr.AddEdge(v1, v2, 6);
            gr.AddEdge(v1, v3, 1);
            gr.AddEdge(v1, v4, 2);
            gr.AddEdge(v2, v3, 4);
            gr.AddEdge(v3, v4, 9);

            gr.ToString();
        }

        public class Node<T>
        {
            public T Data { get; set; }
            public List<Node<T>> AdjencyNode { get; private set; }
            public List<int> Weight { get; private set; }

            public Node()
            {
                AdjencyNode = new List<Node<T>>();
                Weight = new List<int>();
            }

            public Node(T data) : this()
            {
                Data = data;
            }
        }
        public class Graph<T>
        {
            private List<Node<T>> nodes;

            private bool directiedGraph;

            public Graph(bool directiedGraph = false)
            {
                this.nodes = new List<Node<T>>();
                this.directiedGraph = directiedGraph;
            }

            public Node<T> AddVertex(T data)
            {
                return AddVertex(new Node<T>(data));
            }

            public Node<T> AddVertex(Node<T> node)
            {
                nodes.Add(node);
                return node;
            }
            
            public void AddEdge(Node<T> from, Node<T> to, int weight= 1)
            {
                from.AdjencyNode.Add(to);
                from.Weight.Add(weight);
                
                if (!directiedGraph)
                {
                    to.AdjencyNode.Add(from);
                    to.Weight.Add(weight);
                }
            }

            public override string ToString()
            {
                foreach (var item in nodes)
                {
                    for (int i = 0; i < item.AdjencyNode.Count; i++)
                    {
                        Console.WriteLine(item.Data + "--" + item.Weight[i] + "--" + item.AdjencyNode[i].Data);
                    }
                }
                return "";
            }
        }
    }


}
