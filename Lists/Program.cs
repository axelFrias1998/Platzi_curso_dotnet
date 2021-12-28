using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tacoShoppingList = new List<string>();
            tacoShoppingList.Add("Cuatro de suadero");
            tacoShoppingList.Add("Cinco de tripa");
            tacoShoppingList.Add("Siete de pastor");
            tacoShoppingList.Add("Cuatro Coca-Colas");
            tacoShoppingList.Add("Cinco Fantas");

            for (int i = 0; i < tacoShoppingList.Count; i++)
                Console.WriteLine(tacoShoppingList[i]);
            
            tacoShoppingList.Remove("Cinco de tripa");
            tacoShoppingList.RemoveAt(3);
            
        }
    }
}
