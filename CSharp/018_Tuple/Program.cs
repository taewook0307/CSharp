namespace _018_Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<int, string>> tuples = new List<Tuple<int, string>>();

            tuples.Add(new Tuple<int, string>(1, "삼성전자"));
            tuples.Add(new Tuple<int, string>(2, "현대"));
            tuples.Add(new Tuple<int, string>(3, "KIA"));
            tuples.Add(new Tuple<int, string>(4, "LG"));
            tuples.Add(new Tuple<int, string>(5, "APPLE"));

            foreach (Tuple<int, string> tuple in tuples)
            {
                Console.WriteLine($"{tuple.Item1} : {tuple.Item2}");
            }
        }
    }
}
