﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace _133_File_BitConverter
{
    internal class Program
    {
        const string fileName = "a.txt";

        static void Main(string[] args)
        {
            // 파일 쓰기
            long lValue = 1234567890123456789;
            int num = 100;
            Console.WriteLine("lValue : " + lValue);
            Console.WriteLine("num : " + num);

            Stream outStream = new FileStream(fileName, FileMode.Create);
            byte[] wByte = BitConverter.GetBytes(lValue);

            Console.Write("Byte : ");

            foreach (var item in wByte) Console.Write("{0:X2} ", item);
            Console.WriteLine();
            
            outStream.Write(wByte, 0, wByte.Length);

            wByte = BitConverter.GetBytes(num); // sizeof(int)

            Console.Write("Byte : ");

            foreach (var item in wByte) Console.Write("{0:X2} ", item);
            Console.WriteLine();

            outStream.Write(wByte, 0, wByte.Length);

            outStream.Close();

            // 파일 읽기
            FileStream inStream = new FileStream(fileName, FileMode.Open);  

            // rByte의 길이만큼 데이터를 읽어 rBytes에 저장
            byte[] rbytes = new byte[sizeof(long)];
            inStream.Read(rbytes, 0, rbytes.Length);
            long readValue = BitConverter.ToInt64(rbytes, 0);

            rbytes = new byte[sizeof(int)];
            inStream.Read(rbytes, 0, rbytes.Length);
            int readNum = BitConverter.ToInt32(rbytes, 0);

            Console.WriteLine("Read Data : " + readValue);
            Console.WriteLine("Read Data : " + readNum);

            inStream.Close();
        }
    }
}
