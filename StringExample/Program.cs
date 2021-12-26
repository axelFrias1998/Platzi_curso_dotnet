using System;

namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? Please write your full name: ");
            string fullName = Console.ReadLine();
            Console.WriteLine($"Welcome, {fullName}!");
        }
    }
}
