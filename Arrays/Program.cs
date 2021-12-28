using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coffeeTypes;
            float[] coffeePrices;

            coffeeTypes = new string[] { "Expresso", "Large", "Latte", "Moka"};
            coffeePrices = new float[] { 20.4f, 19.5f, 24.5f, 20 };

            for (int i = 0; i < coffeeTypes.Length; i++)
                Console.WriteLine($"Type: {coffeeTypes[i]} \tCost: ${coffeePrices[i]}");
            
            
        }
    }
}
