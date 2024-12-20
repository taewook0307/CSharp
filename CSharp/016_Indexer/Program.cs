namespace _016_Indexer
{
    internal class SquareCalculator
    {
        // indexer 선언
        // 해당 클래스 인스턴스의 []의 반환형은 int형
        // []안에 값은 int
        public int this[int i]
        {
            get
            {
                return i * i;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SquareCalculator square = new SquareCalculator();
            Console.WriteLine(square[10]);
            Console.WriteLine(square[20]);
            Console.WriteLine(square[40]);
        }
    }
}
