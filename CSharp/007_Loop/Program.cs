// See https://aka.ms/new-console-template for more information

// while문

int Count = 1;

while (true)
{
    if(Count > 10)
    {
        // 반복문을 벗어남
        break;
    }

    Console.WriteLine("While문 : " + Count);

    ++Count;
}

/*

조건이 참이면 실행문 반복

while(조건)
{
    (실행문)
}

*/

// do while문

Count = 1;

do
{
    if (Count > 10)
    {
        break;
    }

    if(Count % 2 == 0)
    {
        ++Count;
        // 현재 반복만 멈추고 다음 반복을 진행
        continue;
    }

    Console.WriteLine("Do While문 : " + Count);
    
    ++Count;
    
} while (true);

/*

실행문 한 번 실행 후 조건 확인

do
{
    (실행문)
} while (조건);

*/

// for문

for(int i = 0; i < Count; ++i)
{
    Console.WriteLine("for문 : " + i);
}

/*

초기식을 실행 후 조건식을 확인
조건식이 참일 경우 실행문 실행
실행문 실행후 종결식 실행

for(초기삭;조건식;종결식)
{
    (실행문)
}

*/

// foreach 문

int[] intArray = { 1, 2, 3, 4, 5 };

foreach(int i in intArray)
{
    Console.WriteLine("foreach문 : " + i);
}

/*
컬렉션에 쉽게 반복문을 적용할 때 사용
컬렉션 : 여러 개체가 모여서 집합을 이룬 것 ex) 배열

foreach(자료형 변수 in 컬렉션)
{
    (실행문)
}

*/