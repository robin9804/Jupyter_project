#include <iostream>
#include <fstream>  // 파일 읽기 쓰기 스트림
#include <cassert>
using namespace std;

// 2강 함수, 에러처리, 파일 인/아웃

void increase(int x)
{
    x++; // x의 증가를 반환하는 함수 
}

void RefIncrease(int& x)
{
    x++;  // 변수 자체를 수정하는 함수
}

// 함수 오버로딩
int overload(int a, int b)
{
    int result = a + b;
    assert(result >= 0.0);  // 오류를 검사하는 함수 
    return a + b; 
}
float overload(float a, float b)
{
    // 타입이 다르기 때문에 오버로드가 가능하다. 
    return a + b;
}

int lec2() {
    int i = 3;
    cout << "original i = " << i << "\n" << endl;

    increase(i);  // 값에 의한 호출
    cout << "the result is = "<< i << endl; // 변수 자체가 증가하진 않는다.

    RefIncrease(i);  // 레퍼런스 호출
    cout << "reference result is = "<< i << endl; // 변수 자체가 증가하는    
    int b;
    // 트라이 - 캐치 문
    try
    {
        cin>>b; // b 입력
    } catch (...)
    {
        // 모든 에러를 잡기
 
        cout << "zero division error" << endl;
        b += 1;
    }
    ofstream file;  // file 객체 생성
    file.open("filename.txt");  // 파일 열기, 없으면 파일을 만든다.
    file << "파일에 내용을 입력";
    file.close();  // 열려있는 파일 닫기
    return 0;
}

