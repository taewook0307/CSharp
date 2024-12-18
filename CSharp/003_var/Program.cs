using System;

namespace MyApp
{
    internal class Program
    {
        // 전역변수 사용 불가능
        // var Global = 123;

        static void Main(string[] args)
        {
            var number = 123;

            Console.WriteLine(number);

            // 다른 형식의 값 대입 불가능
            // number = "123";
        }
    }
}

/*
var 키워드
컴파일러가 초기값을 기준으로 자료형을 유추하여 지정해주는 키워드

사용 조건
- 지역 변수로 선언
- 선언과 동시에 초기화

주의
- 한 번 자료형이 결정되면 다른 형식의 값을 대입 불가능
*/