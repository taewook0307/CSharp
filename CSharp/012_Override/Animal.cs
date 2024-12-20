using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAnimal
{
    internal class Animal
    {
        public Animal() { }

        public virtual void Eat()
        {
            Console.WriteLine("먹습니다");
        }
    }

    internal class Dog : Animal
    {
        public Dog()
            : base()
        {
        }

        // 오버라이드
        public override void Eat()
        {
            Console.WriteLine("강아지가 먹습니다.");
        }
    }

    internal class Cat : Animal
    {
        public Cat()
            : base()
        {
        }

        // 하이딩
        public new void Eat()
        {
            Console.WriteLine("고양이가 먹습니다.");
        }
    }
}
