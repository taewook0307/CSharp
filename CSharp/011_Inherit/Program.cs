using System;
using AllAnimal;

namespace _011_Inherit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Cat("네코", "미야옹"));

            foreach(Animal animal in animals)
            {
                if(animal is Dog)
                {
                    // 일반적인 자료형 변환
                    // 변환에 실패하면 예외가 발생
                    ((Dog)animal).Bark();
                }

                // as키워드 변환
                // as 키워드 사용 시 변환할 수 없으면 결과값 null
                Cat cat = animal as Cat;

                if(cat != null)
                {
                    cat.Meow();
                }
            }
        }
    }
}
