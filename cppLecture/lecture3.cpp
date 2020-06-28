#include <iostream>
#include <memory>
using namespace std;

// 3강 : 배열과 포인터, 레퍼런스
void vadd(unsigned size, const double v1[], const double v2[], double s[])
{
    // 벡터를 더해주는 함수
    for (unsigned i = 0; i<size; ++i)
        s[i] = v1[i] + v2[i]; 
}

unique_ptr<double> f()  // 함수에서 반환할 때 메모리의 소유권을 저장하기
{   return unique_ptr<double> {new double}; }

int lc3() 
{
    int v[3];  // 10칸 짜리 배열 (array)
    float a1[] ={1., 2., 3., 4., 5.}, a2[]={1.5, 2.5, 3.5, 4.5, 5.5}, sum[5];  // 정의와 동시에 초기화
    float a3[3][4];  // 3x4 행렬

    for (int i=0; i<3; i++)
    {
        v[i] = a1[i] * 3;
    }
    cout << v[1] << endl;
    //vadd(sizeof a1 / sizeof a1[0], a1, a2, sum);  
    // 배열의 길이 반환하기 sizeof 배열 / sizeof 배열[0]
    cout << "\n SUM of vector is =" << endl;

    // 포인터
    int* y = new int[10]; // 동적 크기 할당
    delete[] y;  // 메모리 해제

    int example = 3;
    int* pointer = &example; // ex의 주소를 반환하기
    int j = *pointer; // 포인터 주소를 통해 포인터가 가르키는 예시를 출력

    // 스마트 포인터, 자동적으로 사용이 끝나면 주소를 delete 한다. 
    unique_ptr<double> dp{new double};
    *dp = 7;
    double* data_dp = dp.get();  // 스마트 포인터의 데이터 얻기
    unique_ptr<double> dp2;
    dp2 = f();

    // shared pointer 역시 존재한다
    
    // 레퍼런스
    int jk = 7;
    int& k = jk;  // jk를 참조하는 
    k = 4;
    cout << "i is " << jk; // 4가 결과값으로 나온다. 
    return 0;
}

