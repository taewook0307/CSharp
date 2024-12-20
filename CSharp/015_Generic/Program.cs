using System.ComponentModel;
using System.Numerics;

namespace _015_Generic
{
    internal class Storege<T>
    {
        private T? thing;

        public Storege(T? Thing) { this.thing = Thing; }

        public T Value
        {
            get
            {
                return thing;
            }

            set
            {
                thing = value;
            }
        }
    }

    // 두개 이상의 Generic을 사용 시 , 를 이용
    internal class TwoGeneric<T, U>
    {

    }

    // where 키워드를 통해 Generic에 자료형을 제한
    internal class LimitGeneric<T, U>
        where T : class
        where U : struct
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
