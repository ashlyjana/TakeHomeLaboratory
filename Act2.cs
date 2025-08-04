using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = new string[5]; 
            int appleCount = 0;              

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.Write("Enter a favorite fruit name: ");
                fruits[i] = Console.ReadLine().ToLower(); 

                if (fruits[i] == "apple")
                {
                    appleCount++; 
                }
            }

            Console.WriteLine("You entered the following fruits:");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine("- " + fruits[i]); 
            }

            Console.WriteLine("You entered {0} apple(s).", appleCount); 
        }
    }
}
