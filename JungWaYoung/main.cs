#define Test

using System;
using System.Text;
using System.Threading.Tasks;

/* 
델리게이트 실행 프로그램임니다.

*/

namespace JHW
{
    class MainClass 
    {
        public const int year = 1995;

        void Hello(string str) // 괄호 안에 매개변수 str, 일반 메소드
        {
            Console.WriteLine(str);
        }
        static void stHello(string str) // 정적 메소드 -> ob.stHello("매개변수") 로 받아서 수행(ob는 델리게이트)
        {
            Console.WriteLine(str);
        }

        public static void Main (string[] args) 
        {
            int a = 50;
            int b;
            b = year +10;

#if (Test)
            Console.WriteLine(b); // 만약 위에 test가 있으면 수행
            Console.WriteLine("전처리기 수행");
#else
            Console.WriteLine(a);
            Console.WriteLine("전처리기 수행하지 않기");
#endif 
// 전처리기 끝! 이런것들은 한 덩어리로 사용해야 한다.

            Console.WriteLine("what it tis?");
            //o.Hello("hello"); // o? 는 instance!
        }
    }
}
