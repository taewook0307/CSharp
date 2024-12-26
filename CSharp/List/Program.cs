namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 인덱스를 통한 접근이 가능한 자료구조
            // 기존에 할당된 크기보다 많은 데이터가 저장 시 전체 복사 발생
            List<string> Names = new List<string>();

            // 미리 Capacity를 바꿔 공간을 할당한 후 사용하는게 좋음
            Names.Capacity = 6;

            Names.Add("Rupy");
            Names.Add("Zoro");
            Names.Add("Nammy");
            Names.Add("Robbin");

            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }

            string indexName = Names[2];
            Console.WriteLine(indexName);

            Console.WriteLine($"Count = {Names.Count}");
            Console.WriteLine($"Capacity = {Names.Capacity}");

            // Clear 후 Capacity는 그대로 남아있음
            Names.Clear();
            Console.WriteLine("Clear");
            Console.WriteLine($"Count = {Names.Count}");
            Console.WriteLine($"Capacity = {Names.Capacity}");

            //string indexOverName = Names[3];
        }
    }
}
