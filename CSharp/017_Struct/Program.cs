namespace _017_Struct
{
    struct Point
    {
        public int x;
        public int y;

        // 매개 변수 없는 생성자는 기본으로 생성됨
        // 매개 변수 없는 생성자에서는 기본값으로 초기화 ex) int -> 0
        //public Point()
        //{
        //    x = 0;
        //    y = 0;
        //}

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public Point(int _x)
        {
            x = _x;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();

            Point point1 = new Point(1);

            Console.WriteLine(point.x + ", " + point.y);
            Console.WriteLine(point1.x + ", " + point1.y);
            // 초기화 부분 없을 시 오류 발생
            point.x = 10;
            point.y = 20;

            Console.WriteLine(point.x + ", " + point.y);
        }
    }
}
