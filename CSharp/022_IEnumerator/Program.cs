namespace MyApp
{
    internal class Program
    {
        static IEnumerable<int> GenericTest()
        {
            yield return 1;
            Console.WriteLine("yield return 1 after");
            yield return 2;
            Console.WriteLine("yield return 2 after");
            yield return 3;
            Console.WriteLine("yield return 3 after");
            yield return 4;
            Console.WriteLine("yield return 4 after");
        }
    
        static void Main(string[] args)
        {
            foreach (int number in GenericTest())
            {
                Console.WriteLine(number);
            }
        }
    }
}