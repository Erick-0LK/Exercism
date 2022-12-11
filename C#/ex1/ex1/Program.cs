using System;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HelloWorld.Hello());
        }
    }

    public static class HelloWorld
    {
        public static string Hello() => "Hello, World!";
    }
}