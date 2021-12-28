using System;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the area of a triangle");
            
            //Sides
            int sideA = 10;
            float sideB = 20.2f;

            // A = a * b
            float area = sideA + sideB;
            Console.WriteLine($"Area = {area}");
        }
    }
}
