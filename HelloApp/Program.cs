using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello everyone");
            GreetWhite();
            GreetBlack();
        }
        static void GreetWhite()
        {
            Console.WriteLine("hello white");
        }
        static void GreetBlack()
        {
            Console.WriteLine("hello black");
        }
    }
}