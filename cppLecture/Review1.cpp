
#include <iostream>
#include <valarray>
using namespace std;

void func(int, int = 10);  // 미리 선언 초기화

int main()
{
    valarray<float> v1 = {1, 2, 3},
                    v2 = {4, 5, 6},
                    s = v1 + 0.2f * v2;  // 벡터간 연산
    v1 = sin(s);
    
    for(float x : v1)
        cout << x << "  " ;
    cout << endl;
    
    func(v1[1], v2[0]);    
}

void func(int a, int b)  // 여기서는 초기화x
{
    printf("a is %d, b is %d\n", a, b);
}
