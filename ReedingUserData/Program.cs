using System;

namespace ReedingUserData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the area of a triangle");
            
            //Sides
            Console.Write("Side A: ");
            float sideA = float.Parse(Console.ReadLine());
            
            Console.Write("Side B: ");
            float sideB = float.Parse(Console.ReadLine());

            // A = a * b
            float area = sideA + sideB;
            Console.WriteLine($"Area = {area}");
        }
    }
}
