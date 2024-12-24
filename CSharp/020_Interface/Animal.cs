using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Interface
{
    internal class Animal
    {
        virtual public void Eat()
        {
            Console.WriteLine("먹습니다");
        }
    }

    // 인터페이스는 내부에 메소드, 이벤트, 인덱서, 프로퍼티만 가질 수 있음
    // 접근 제한자를 사용할 수 없고 모든 것이 public으로 선언됨
    // 자신을 상속받은 클래스에게 오버라이딩을 강제함
    // 구현부 없음
    interface ICanFly
    {
        void Fly();
        void Fly(int _speed);
    }

    abstract class FlyUnit
    {
        public abstract void Fly();
    }

    // 클래스는 여러 클래스(추상 클래스 포함)를 상속받을 수 없지만 여러 인터페이스는 상속 가능
    internal class Bird : Animal, ICanFly/*, FlyUnit*/
    {
        public override void Eat()
        {
            Console.WriteLine("새가 먹습니다.");
        }

        public void Fly()
        {
            Console.WriteLine("새가 납니다.");
        }

        public void Fly(int _speed)
        {
            Console.WriteLine(_speed + "의 속도로 납니다");
        }
    }
}
