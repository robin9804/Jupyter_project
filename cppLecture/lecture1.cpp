#include <iostream>
#include <string>
using namespace std; // std를 안쳐도 되게끔 네임스페이스 설정ㅎㅎ

int lecture1() {
    // 1강 연산자와 타입
    int a = {100};  // a에 저장된 값은 이제 축소할 수 없다. 데이터가 축소되지 않음 (예 3.14 -> 3 이 되지 않음)
    const float r1 = 3.5, r2 = 7.3, pi = 3.141592;
    float area1 = pi * r1 * r1;

    cout << "area r1 =" << area1 << std::endl;
    std::cout << "average of r = " << (r1 + r2) / 2 << std::endl;  // 나누기의 타입으로 변환된다

    std::cout << sizeof pi << std::endl;  // r1 변수의 사이즈 반환
    
    // if 문과 for 문을 사용해 봅시다
    if(r1 > 2.0)
        std::cout << r1;
    else if(r1 == 2.0)
        std::cout << "r1 is 2";
    else
    {
        cout<< r1;
        cout << "r1 is enough"; 
    }
    // 조건식
    int kin = a < r1 ? a%2 : r1; // 더 작은 쪽을 반환
    
    // 벡터 더하기 예제
    double v[3], w[] = {2., 4., 6.}, x[] = {6., 5., 4};
    for(int i = 0; i < 3; i++){  // 1부터 시작하는 배열이 되어버렸다. 
        v[i] = w[i] + x[i];
        cout << v[i] << endl;
    } 

    // 범위 기반 for 문
    for (int i : x )
    {
        cout << "x is like this = " << i << endl;  // x 배열의 요소를 반환
    }
    return 0;
}