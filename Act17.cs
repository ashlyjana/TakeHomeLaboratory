using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[8];
            Console.WriteLine(" Enter a 8 whole numbers:");

            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Number {i + 1}:");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Number Categorys:");

            for (int i = 0; i < 8; i++)
            {

                int num = numbers[i];
                string binary = Convert.ToString(num);
                string evenOdd = "Odd";
                if (num % 2 == 0)
                    evenOdd = "Even";
                string PrimeStatus = "no";
      
                if (IsPrime(num))
                    PrimeStatus = "yes";

                Console.WriteLine("Number:" + num);
                Console.WriteLine("Binary:" + binary);
                Console.WriteLine("Even or Odd:" + evenOdd);
                Console.WriteLine("Prime:" + PrimeStatus);
            }
             bool IsPrime(int number)
            {
                if (number <= 1) return false;
                for (int i = 2; i <= number / 2; i++) { 
                    if (number % i == 0) return false;
                }
                return true;
            }


        }
    }
}
