// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bool Size : " + sizeof(bool));
            Console.WriteLine("char Size : " + sizeof(char));
            Console.WriteLine("short Size : " + sizeof(short));
            Console.WriteLine("int Size : " + sizeof(int));
            Console.WriteLine("long Size : " + sizeof(long));
            Console.WriteLine("float Size : " + sizeof(float));
            Console.WriteLine("double Size : " + sizeof(double));
        }
    }
}