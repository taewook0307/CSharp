namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Key를 기준으로 정렬하여 데이터를 저장하는 구조
            // Key값의 중복 허용 X
            SortedList<int, string> students = new SortedList<int, string>();

            students.Add(4, "Tearia");
            students.Add(1, "Setuna");
            students.Add(3, "Alreruya");
            students.Add(2, "Rockon");

            foreach (KeyValuePair<int, string> kvp in students)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }
        }
    }
}
