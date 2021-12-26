using System;

namespace NumericCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.WriteLine("Input the first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The result is: {number1 + number2}");
        }
    }
}
