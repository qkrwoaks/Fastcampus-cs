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
                        SortId(listData);
                        break;
                    case "2":
                        SortTotal(listData);
                        break;
                    case "3":
                        SortKor(listData);
                        break;
                    case "4":
                        FindDataUp(listData, true);
                        break;
                    case "5":
                        FindDataUp(listData, false);
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

        static void SortId(List<CStudent> _listData)
        {
            _listData.Sort(delegate (CStudent a, CStudent b)
            {
                if (a.Id > b.Id) return 1;
                else if (a.Id < b.Id) return -1;
                else return 0;
            });

            Console.WriteLine("아이디 정렬");
            PrintList(_listData);
        }

        static void SortTotal(List<CStudent> _listData)
        {
            var items = from item in _listData
                        orderby item.Total descending
                        select item;

            List<CStudent> sortData = items.ToList<CStudent>();

            Console.WriteLine("총점 정렬");
            PrintList(sortData);
        }

        static void SortKor(List<CStudent> _listData)
        {
            _listData.Sort((CStudent a, CStudent b) => { return b.Kor - a.Kor; });

            Console.WriteLine("국어 점수 정렬");
            PrintList(_listData);
        }

        static void FindDataUp(List<CStudent> _listData, bool isUp)
        {
            Console.WriteLine("총점 이상을 찾을까요?(점수를 입력하세요)");
            string inputData = Console.ReadLine();
            int num = 0;

            try
            {
                num = int.Parse(inputData);
            }
            catch (FormatException e)
            {
                Console.Clear();
                Console.WriteLine("입력값 {0} 잘못된 입력입니다. 숫자만 입력하세요!!", num);
            }
            finally
            {
                if (num <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("입력값 {0} 잘못된 입력입니다. 작은 수 입니다.!!", num);
                }

                if (num >= 300)
                {
                    Console.Clear();
                    Console.WriteLine("입력값 {0} 잘못된 입력입니다. 큰 수 입니다.!!", num);
                }
            }

            if (num >= 0 && num <= 300)
            {
                if (isUp)
                {
                    var findData =
                        from item in _listData
                        where item.Total >= num
                        select item;

                    List<CStudent> toData = findData.ToList<CStudent>();
                    PrintList(toData);
                    SortId(toData);
                    SortTotal(toData);
                }
                else
                {
                    List<CStudent> findList = _listData.FindAll((data) => data.Total <= num);

                    PrintList(findList);

                    SortId(findList);

                    SortTotal(findList);
                }
            }
        }
    }
}
