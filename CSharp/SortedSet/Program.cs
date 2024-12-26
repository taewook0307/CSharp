using System.Runtime.CompilerServices;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 이진트리를 이용하여 데이터를 정렬하여 저장하는 Set
            SortedSet<int> numbers = new SortedSet<int>();

            numbers.Add(99);
            numbers.Add(39);
            numbers.Add(62);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
