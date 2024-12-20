namespace _014_Abstract
{
    internal abstract class FlyUnit
    {
        // abstract 메서드는 abstract 클래스에서만 선언 가능
        public abstract void Fly();
    }

    internal class Airplane : FlyUnit
    {
        // abstract 메서드는 반드시 재정의 필요
        public override void Fly()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // abstract로 선언된 클래스는 인스턴스 생성 불가능
            // FlyUnit Error = new FlyUnit();
        }
    }
}
