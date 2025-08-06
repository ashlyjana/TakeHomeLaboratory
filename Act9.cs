using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] number = new int[3];
            Console.WriteLine("Enter three numbers:");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Multiplication table:");
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine($"Multiplication table of {number[i]}:");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{number[i]} x {j} = {number[i] * j}");
                }
                Console.WriteLine();
            }


        }
    }
}
