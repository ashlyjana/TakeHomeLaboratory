using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Act5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[10];
            int EvenCount = 0;
            int OddCount = 0;
            int divisibleBy5Count = 0;

            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                number[i] = int.Parse(Console.ReadLine());
                if (number[i] % 2 == 0)
                {
                    EvenCount++;
                }
                else
                {
                    OddCount++;
                }
                if (number[i] % 5 == 0)
                {
                    divisibleBy5Count++;
                }
            }
            Console.WriteLine($"\nTotal even numbers: {EvenCount}");
            Console.WriteLine($"Total odd numbers: {OddCount}");
            Console.WriteLine($"Total numbers divisible by 5: {divisibleBy5Count}");
        }
    }
}
