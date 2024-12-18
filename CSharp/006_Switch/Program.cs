// See https://aka.ms/new-console-template for more information


Console.WriteLine("1. 메뉴 선택\t2. 메뉴 추가\t3. 메뉴 삭제");
string selectNum = Console.ReadLine();
int Num = int.Parse(selectNum);

switch(Num)
{
    case 1:
        Console.WriteLine("메뉴를 선택합니다");
        break;
    case 2:
        Console.WriteLine("메뉴를 추가합니다");
        break;
    case 3:
        Console.WriteLine("메뉴를 삭제합니다");
        break;
    default:
        Console.WriteLine("잘못된 방식입니다.");
        break;
}


/*

if문과 swtich문의 다른점

if문의 경우 조건문이 다른지 확인

switch에 경우 점프 테이블을 생성하여 최적화(무조건 점프테이블 이용 X)

점프 테이블
특수 조건에 따라 프로그램 실행 경로를 빠르게 선택하기 위한 데이터 구조(배열)
각 switch의 case문에 따라 인덱스를 가짐(값 - 인덱스 매핑)
인덱스 범위 초과 시 default로 점프
연속적이고 정수형 값에 경우에 효율적

비연속적인 값에 경우 처리가 적합하지 않음
문자열을 조건으로 사용 시 점프테이블 생성 X(다른 방식으로 최적화)



*/