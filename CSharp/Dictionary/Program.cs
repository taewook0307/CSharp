namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Key와 Value를 통해 데이터를 저장
            // 해시 테이블을 통해 데이터 접근이 빠름 : 시간복잡도 O(1)
            Dictionary<char, string> dicColor = new Dictionary<char, string>();

            dicColor.Add('R', "Red");
            dicColor.Add('G', "Green");
            dicColor.Add('B', "Blue");

            // Dictionary는 중복 허용 X
            // dicColor.Add('B', "Black");

            // KeyValuePair
            foreach (KeyValuePair<char, string> curColor in dicColor)
            {
                Console.WriteLine($"{curColor.Key} = {curColor.Value}");
            }
        }
    }
}
