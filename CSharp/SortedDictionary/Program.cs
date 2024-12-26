namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 이진 검색 트리를 통해 데이터를 관리
            // 키 값을 기준으로 정렬
            SortedDictionary<int, string> sD = new SortedDictionary<int, string>();

            sD.Add(4, "Black");
            sD.Add(2, "Blue");
            sD.Add(1, "Red");
            sD.Add(3, "Orange");

            // Key 값의 중복 허용 X
            // sD.Add(1, "White");

            foreach (KeyValuePair<int, string> kvp in sD)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }
        }
    }
}
