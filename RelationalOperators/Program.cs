using System;

namespace RelationalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 3;
            int value2 = 18;
            int value3 = -18;

            /*
            == Equal
            != Not equal
            > Greater than
            < Less than
            >= Greater or equal than
            <= Less or equal than
            */
            Console.WriteLine($"The result of {value1} == 3 is: {value1 == 3}");
            Console.WriteLine($"The result of {value1} != {value2} is: {value1 != value2}");
            Console.WriteLine($"The result of {value1} > {value3} is: {value2 > value3}");
            Console.WriteLine($"The result of {value1} < {value3} is: {value2 < value3}");
            Console.WriteLine($"The result of {value1} >= {value3} is: {value1 >= value3}");
            Console.WriteLine($"The result of {value1} <= -18 is: {value3 <= -18}");

        }
    }
}
