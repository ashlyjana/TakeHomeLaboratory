using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];
            int[] ages = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter name {i + 1}: ");
                names[i] = Console.ReadLine();

                Console.Write($"Enter age {i + 1}: ");
                string input = Console.ReadLine();
                int age = int.Parse(input);
                ages[i] = age;
            }

            Console.WriteLine("\nVoter Eligibility and Categorization:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Name: {names[i]}, Age: {ages[i]} - ");

                if (ages[i] < 18)
                {
                    Console.WriteLine("Not eligible to vote.");
                }
                else if (ages[i] <= 30)
                {
                    Console.WriteLine("Young Voter");
                }
                else if (ages[i] <= 59)
                {
                    Console.WriteLine("Mid-age Voter");
                }
                else
                {
                    Console.WriteLine("Senior Voter");
                }
            }
        }
    }
}
