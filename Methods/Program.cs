using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(1, 10));
        }
    }
}
