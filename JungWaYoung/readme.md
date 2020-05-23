## 델리게이트란?
event, thread를 처리하는 데 사용한다. 대리자! stop watch와 같은 역할?


# 델리게이트 생성 방법?
1) delegate 할 메소드 정하기
2) 메소드에 맞는 delegate 선언 - return type과 변수가 일치해야 한다.
3) 임의 객체 생성(객체 기반 조종)
4) delegate 생성과 호출 -> 명령!

구현?
delegate 호출로 전환이 가능!

쓰레드? - 델리게이트를 기본으로 사용
예)
(c#)
ThreadTest tt = new ThreadTest(); // 쓰레드 만들기
ThreadStart ts = new ThreadStart( tt.TestThreadMethod); // 쓰레드 스타트! 앞에 만들었던 tt를 실행
Thread t = new Thread(ts); // 새로 Thread를 t에 집어넣고,ts를 실행!
t.Start() // 댈리게이트가 start 실행!


# Window form
[윈도우 프로그램이라고, 윈도우 화면이 막 뜸]

- event?
발생되는 사건. 윈도우는 모든 처리를 이벤트 기반, event driven program
ex) 마우스 무브라고 나온다.
이벤트 처리기? 이벤트가 발생하면 등록된 메소드 처리
이벤트 : 어떤 사건이 발생했을 때 정보 자체를 의미, 윈도우는 대부분 defuault는 누르고 뗀 후에 작업을 처리함(마우스같이)
이 외로 이벤트 발생기, 이벤트 처리기가 있다...

form에서 발생할 수 있는 이벤트?
저어어어엉말 많다? 예) MouseMove, MouseDown... 이런것들로 프로그래머가 알 수 있게 이벤트를 메시지로 등록
프로그램은 메시지를 열어봐서 상태를 알게 된다.

# 전처리기 지시어
실제 컴파일이 시작되기전에 컴파일러 명령 지시, #이 붙는다.
* 맨 첫줄에 위치!, 세미콜론 붙이지 않는다!
예) #define, #undef :조건부 기호 정의,
- #if 는 소스코드의 특정부분을 조건적으로 건너뛴다.

#define
        public static void Main (string[] args) 
        {
            int a = 50;
            int b;
            b = year +10;
#if (Test)
            Console.WriteLine(b); // 만약 위에 test가 있으면 수행
#else
            Console.WriteLine(a);
#endif
            // mainClass 입니다.
            Console.WriteLine("what it tis?");
            //o.Hello("hello"); // o? 는 instance!
        }