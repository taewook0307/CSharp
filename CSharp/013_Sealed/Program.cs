namespace _013_Sealed
{
    internal class Traffic
    {
        public virtual void Run()
        {

        }
    }

    internal sealed class Car : Traffic
    {

    }

    // sealed 키워드를 선언된 클래스는 상속받지 못 함
    //internal class RacingCar : Car
    //{

    //}

    internal class Motorcycle : Traffic
    {
        public sealed override void Run()
        {

        }
    }

    internal class Tricycle : Motorcycle
    {
        // sealed 키워드가 선언된 Run메서드는 override 못 함
        //public override void Run()
        //{

        //}
    }
}
