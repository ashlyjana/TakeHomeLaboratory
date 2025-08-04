using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[5];
            int teenagerCount = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter age of person {0}: ", i + 1);
                int age = int.Parse(Console.ReadLine());

                if (age >= 10 && age <= 99)
                {
                    ages[i] = age; 

                    if (age >= 13 && age <= 19)
                    {
                        teenagerCount++;
                    }
                }
                else
                {
                    Console.WriteLine("Age must be between 10 and 99.");
                    i--; 
                }
            }
            Console.WriteLine("\nValid ages entered:");
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Person {0}: {1}", j + 1, ages[j]); 
            }

            Console.WriteLine("Total number of teenagers: " + teenagerCount);
        }
    }
}
