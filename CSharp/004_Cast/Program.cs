// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 강제 자료형 변환
            {
                long longNum = 3247483647L;
                Console.WriteLine("longNum = " + longNum);

                int intNum = (int)longNum;
                Console.WriteLine("intNum = " + intNum);
                Console.WriteLine();
            }

            // 자동 자료형 변환
            {
                int intNum = 293418;
                Console.WriteLine("intNum = " + intNum);

                long longNum = intNum;
                Console.WriteLine("longNum = " + longNum);

                double doubleNum = intNum;
                Console.WriteLine("doubleNum = " + doubleNum);
                Console.WriteLine();
            }

            // 다른 자료형을 숫자로 변환(Parse Method)
            {
                string numberString = "5683";
                Console.WriteLine("numberString = " + numberString);
                Console.WriteLine("numberString Type : " + numberString.GetType());

                int stringToInt = int.Parse(numberString);
                Console.WriteLine("stringToInt = " + stringToInt);
                Console.WriteLine("stringToInt Type : " + stringToInt.GetType());

                double stringTodouble = double.Parse(numberString);
                Console.WriteLine("stringToDouble = " + stringTodouble);
                Console.WriteLine("stringToDouble Type : " + stringTodouble.GetType());
                Console.WriteLine();

                // 예외 발생(FormatException)
                //string exceptString = "abc";
                //int exceptToInt = int.Parse(exceptString);
                //Console.WriteLine("exceptToInt = " + exceptToInt);
            }

            // 다른 자료형을 문자열로 변환
            {
                int intNum = 12345;
                double doubleNum = 52.3049;
                bool isBool = true;

                string intString = intNum.ToString();
                string doubleString = doubleNum.ToString();
                string boolString = isBool.ToString();

                Console.WriteLine("intString = " + intString);
                Console.WriteLine("intString Type : " + intString.GetType());
                Console.WriteLine("doubleString = " + doubleString);
                Console.WriteLine("doubleString Type : " + doubleString.GetType());
                Console.WriteLine("boolString = " + boolString);
                Console.WriteLine("boolString Type : " + boolString.GetType());
                Console.WriteLine();
            }

            {
                Console.WriteLine('a' + 'b');
                Console.WriteLine(42 + 58);
                Console.WriteLine("42" + 52);
                Console.WriteLine(42 + "52");
            }
        }
    }
}