namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 데이터와 함께 이전/다음 링크 포인터를 저장하는 자료구조
            // 데이터 삽입/삭제는 빠름, 검색은 느림
            LinkedList<string> Road = new LinkedList<string>();

            // 끝에 삽입
            Road.AddLast("A");
            Road.AddLast("E");
            Road.AddLast("C");
            Road.AddLast("B");

            // 정면에 삽입
            Road.AddFirst("D");

            foreach (string item in Road)
            {
                Console.WriteLine(item);
            }
        }
    }
}
