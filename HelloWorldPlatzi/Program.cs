using System;

namespace HelloWorldPlatzi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            float height = 1.7f;
            int age = 23;
            string name = "Axel Frías Hernández";
            string information = "The information you requested is\nName: " + name + "\nAge: "+ age + "\nHeight: " + height;
            Console.WriteLine($"{name}");
            Console.WriteLine(information);
        }
    }
}
