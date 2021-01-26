using System;

namespace methods_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            string name = AskName();
            SayHelloToMe(name);
        }

        // simple method, no parameters, no return value

        static void SayHello()
        {
            Console.WriteLine("Hello World!");
        }

        // no parameters, string return value

        static string AskName()
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            return name;
        }

        // string parameter, no return type

        static void SayHelloToMe(string name)
        {
            Console.WriteLine("Hello to " + name + "!");
        }
    }
}
