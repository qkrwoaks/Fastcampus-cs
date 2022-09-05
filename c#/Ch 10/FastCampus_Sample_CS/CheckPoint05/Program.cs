using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint05
{
    class CStudent
    {
        private int id;
        private int kor;
        private int math;
        private int eng;
        private int total;

        public int Id { get { return id; } }
        public int Kor { get { return kor; } }
        public int Math { get { return math; } }
        public int Eng { get { return eng; } }
        public int Total { get { return total; } }

        public CStudent(int id, int kor, int math, int eng)
        {
            this.id = id;
            this.kor = kor;
            this.math = math;
            this.eng = eng;
            this.total = kor + math + eng;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<CStudent> listData = new List<CStudent>();
            bool isLoop = true;

            InitData(listData);

            // PrintList(listData);
            do
            {
                Console.WriteLine("메뉴를 골라주세요 ? ");
                Console.Write("(1)id 정렬 (2)성적순 정렬 (3)국어점수 정렬 (4)특정점수 이상 (5)특정점수 이하 (0)나가기");
                string inputNum = Console.ReadLine();

                switch (inputNum)
                {
                    case "0":
                        Console.WriteLine("프로그램 종료");
                        isLoop = false;     
                        break;
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("다시 입력하세요 ");
                        break;
                }


            } while (isLoop);
        }

        /// <summary>
        /// 학생 데이터를 생성
        /// 0 0 0 0
        /// 1, ?, ?, ?
        /// </summary>
        /// <param name="_listData"></param>
        static void InitData(List<CStudent> _listData)
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                CStudent data = new CStudent(i, random.Next(0, 100), random.Next(0, 100), random.Next(0, 100));
                _listData.Add(data);
            }
        }

        static void PrintList(List<CStudent> _listData)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", "Id", "Kor", "Math", "Eng", "Total");
            Console.WriteLine("============================================================");

            foreach (var item in _listData)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", item.Id, item.Kor, item.Math, item.Eng, item.Total);
            }
        }
    }
}
