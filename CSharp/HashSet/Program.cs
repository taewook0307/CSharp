namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 해시 테이블을 이용해 빠른 검색이 가능
            // 중복 허용 X
            HashSet<string> strings = new HashSet<string>();

            strings.Add("Rupy");
            strings.Add("Robbin");
            strings.Add("Zoro");

            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }
    }
}
