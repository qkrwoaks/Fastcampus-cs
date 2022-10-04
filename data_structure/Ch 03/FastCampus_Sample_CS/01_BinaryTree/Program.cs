using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

// 트리(Tree) 란?
// 자료 간의 관계가 계층 구조일 때 사용하는 비선형자료구조이다.

// 개념
// 1. 트리는 노드(node)로 이루어진 자료 구조 2. 트리는 하나의 루트 노드를 갖는다. 3. 루트는 노드는 0개 이상의 자식 노드를 갖고 있다.

// 특징
// 1. 그래프의 한 종류이다. '최소 연결 트리'라고도 불린다. 2. 트리는 계층 모델이다. 3. 트리는 DAG(Direted Acycle Graphs, 방향서이 있는 비순환 그래프)의 한종류이다.
// 4. 노드가 N개인 트리는 항상 N - 1개의 간선(edge)을 가진다. 5. 루트에서 어떤 노드로 가는 경로는 유일하다. 6. 한 개의 루트 노드만이 존쟇며 모든 자식 노드는 한 개의 부모 노드만을 가진다.
// 7. 순회 Pre-order, in-order 아니면 Post-order로 이루어진다. 8. 트리는 이진 트리, 이진 탐색 트리, 균형 트리, 이진 힙등이 있다.


// 이진(Binary Tree) 트리란?
// 컴퓨터에서 사용되는 데이터 구조의 하나로, 루트가 있는 트리 구조에서 어떤 노드의 자식의 수가 최대 2개를 넘지 않는 트리를 말한다. 

// 순회
// 이진트리의 순회(traversal)란 이진 트리의 모든 노드를 특정한 순서대로 한 번씩 방문하는 것이다.

// 종류
// 이진 트리의 순회는 전위, 중위 아니며 후위 순회로 이루어지고 3가지 모두 DFS(깊이 우선 탐색)과 BFS(너비 우선 탐색)안에 있다.

namespace _01_BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> bt = new BinaryTree<int>();

            // 
            bt.Insert(4);
            bt.Insert(2);
            bt.Insert(3);
            bt.Insert(6);
            bt.Insert(1);
            bt.Insert(7);
            bt.Insert(5);

            bt.PreOrderTraversal();
        }
    }

    // 이진 트리 클래스
    public class BinaryTree<T>
    {
        private BinaryTreeNode<T> root = null;
        private Comparer<T> comparer = Comparer<T>.Default;
        /// <summary>
        /// 데이터 값 추가 함수
        /// </summary>
        /// <param name="val">데이터 값</param>
        public void Insert(T val)
        {
            BinaryTreeNode<T> node = root;
            if (node == null)
            {
                root = new BinaryTreeNode<T>(val);
                return;
            }
            while (node != null)
            {
                int result = comparer.Compare(node.tData, val);
                // 같은 값인지 검사
                if (result == 0)
                {
                    // throw new InvaildDataException("Duplicate value");
                    return;
                }
                else if (result > 0)
                {
                    if (node.btnLeft == null)
                    {
                        node.btnLeft = new BinaryTreeNode<T>(val);
                        return;
                    }
                    node = node.btnLeft;
                }
                else
                {
                    if (node.btnRight == null)
                    {
                        node.btnRight = new BinaryTreeNode<T>(val);
                        return;
                    }
                    node = node.btnRight;
                }
            }
        }

        public void PreOrderTraversal()
        {
            PreOrderRecursive(root);
        }
        private void PreOrderRecursive(BinaryTreeNode<T> node)
        {
            if (node == null) return;
            Console.Write(node.tData + "->");
            PreOrderRecursive(node.btnLeft);
            PreOrderRecursive(node.btnRight);
        }
    }

    // 이진 트리 클래스
    public class BinaryTreeNode<Tdata>
    {
        public Tdata tData { get; set; } // 데이터 값
        public BinaryTreeNode<Tdata> btnLeft { get; set; } // 왼쪽 이진트리
        public BinaryTreeNode<Tdata> btnRight { get; set; } // 오른쪽 이진트리

        // 생성자
        public BinaryTreeNode(Tdata tdata)
        {
            this.tData = tdata;
        }
    }
}
