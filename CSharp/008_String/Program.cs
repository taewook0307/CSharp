// See https://aka.ms/new-console-template for more information

// 출력 방법
Console.WriteLine("바로 출력");

string str1 = "변수 이용";
Console.Write(str1);

string str2 = "Format 이용";
Console.WriteLine("Format 방식 : {0} {1}", str2, 1);

string str3 = "문자열 보간";
Console.WriteLine($"Format 방식 : {str2} {str3}");

// 대소문자 함수
string s1 = "abcd";

Console.WriteLine(s1.ToUpper());
Console.WriteLine(s1);

string s2 = "ABCD";

Console.WriteLine(s2.ToLower());
Console.WriteLine(s2);

// 문자열 분리 함수
string s3 = "name phone_number address,potato,sweet_potato,tomato";
string[] conditions = s3.Split(new char[] { ' ', ',' });

foreach (string condition in conditions)
{
    Console.WriteLine(condition);
}

// 공백 제거 함수
string s4 = "\t abc dslkfej\t\t";
Console.WriteLine("::" + s4 + "::");
Console.WriteLine("::" + s4.Trim() + "::");
Console.WriteLine("::" + s4.TrimStart() + "::");
Console.WriteLine("::" + s4.TrimEnd() + "::");

string[] Menu = { "Pasta", "Pizza", "Steak" };
string AllMenu = string.Join(", ", Menu);
Console.WriteLine(AllMenu);