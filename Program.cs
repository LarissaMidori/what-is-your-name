using System;

namespace what_is_your_name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"\nHello {name}!!");
        }
    }
}
