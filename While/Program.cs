using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueSoftwareExecution = true;
            Console.WriteLine("Hello World from While!");
            while (continueSoftwareExecution)
            {
                Console.WriteLine("\nDo you wish to continue? (1 = yes, 0 = no): ");
                int keepGoing = Convert.ToInt16(Console.ReadLine()); 
                if(keepGoing == 0)
                    continueSoftwareExecution = false;
                else if(keepGoing == 1)
                    Console.WriteLine("Let's do it again!\n");
                else
                    Console.WriteLine("Invalid input. Try again");
            }
            Console.WriteLine("Bye!");
        }
    }
}
