using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _136_File_BinaryFormatter02
{
    [Serializable]
    struct Player
    {
        public string _Name;
        public int _Level;
        public double _Exp;
    }
    internal class Program
    {
        const string fileName = "list.dat";
        static void Main(string[] args)
        {
            List<Player> listPlayers = new List<Player>();

            for (int i = 0; i < 10; i++)
            {
                Player player = new Player();
                player._Name = i.ToString();
                player._Level = i;
                player._Exp = i * 10;

                listPlayers.Add(player);
            }

            // 쓰기
            FileStream fsW = new FileStream(fileName, FileMode.Create);

            BinaryFormatter bfW = new BinaryFormatter();
            bfW.Serialize(fsW, listPlayers);

            fsW.Close();

            // 읽기
            FileStream fsr = new FileStream(fileName, FileMode.Open);

            BinaryFormatter bfr = new BinaryFormatter();
            List<Player> readPlayers = (List<Player>)bfr.Deserialize(fsW);

            foreach (var data in readPlayers)
            {
                Console.WriteLine("_Name : {0} _Level : {1} _Exp : {2}", data._Name, data._Level, data._Exp);
            }

            fsr.Close();
        }
    }
}
