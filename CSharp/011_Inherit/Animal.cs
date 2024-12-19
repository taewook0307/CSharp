using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AllAnimal
{
    internal class Animal
    {
        protected string name = "";
        protected string cryingSound = "";

        public Animal(string _name, string _cryingSound)
        {
            name = _name;
            cryingSound = _cryingSound;
        }

        public void Eat()
        {
            Console.WriteLine(name + "가 밥을 먹습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine(name + "가 잡니다.");
        }

        public void Cry()
        {
            Console.WriteLine(name + "가 " +  cryingSound + "하고 웁니다.");
        }
    }

    // 상속을 통해 부모의 public, protected 로 지정된 멤버는 접근 가능
    // [접근 제한자] class [자식 클래스 이름] : [부모 클래스 이름]

    internal class Dog : Animal
    {
        public Dog(string _name = "강아지", string _cryingSound = "왈왈")
            : base(_name, _cryingSound)
        {

        }

        public void Bark()
        {
            Eat();
            Cry();
            Sleep();
        }
    }

    internal class Cat : Animal
    {
        public Cat(string _name = "고양이", string _cryingSound = "야옹")
            : base(_name, _cryingSound)
        {

        }

        public void Meow()
        {
            Eat();
            Cry();
            Sleep();
        }
    }
}
