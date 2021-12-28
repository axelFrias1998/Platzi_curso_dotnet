using System;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool value1 = true;
            bool value2 = false;
            Console.WriteLine($"The result of logical AND is: {value1 && value2}");
            Console.WriteLine($"The result of logical OR is: {value1 || value2}");
            Console.WriteLine($"The result of logical NOT AND is: {!(value1 && value2)}");
            Console.WriteLine($"The result of logical NOT OR is: {!(value1 || value2)}");
        }
    }
}
