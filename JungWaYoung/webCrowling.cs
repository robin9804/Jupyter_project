using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;  // 네트워크에 관련된 부분

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 웹 크롤링
            int maxlen = 2048;  // 버퍼를 설정 (최대 가져올 데이터 크기)
            char[] buffer = new char[maxlen];

            // url 설정
            WebRequest req = WebRequest.Create("http://www.khu.ac.kr");
            WebResponse res = req.GetResponse(); // 리퀘스트에 대한 리스폰스를 받아라

            // 스트림으로 가져오기
            StreamReader sreader = new StreamReader(res.GetResponseStream(), System.Text.Encoding.Default);

            int i = 0;
            do
            {
                i = sreader.Read(buffer, 0, maxlen);
                Console.WriteLine(buffer, 0, i);  // i 까지 읽어오기
            }
            while (i > 0);
        }
    }
}
