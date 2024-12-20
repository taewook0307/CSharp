using AllAnimal;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.Eat();
            Animal cat = new Cat();
            cat.Eat();
        }
    }
}
