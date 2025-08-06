using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] Celsius = new double[5];
            double Fahrenheit;

            Console.Write("Enter 5 temperatures in celsius:");

            for (int i = 0; i < Celsius.Length; i++)
            {
                Console.Write($"Temperature {i + 1}: ");
                Celsius[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Converted and category:");
            for (int i = 0; i < Celsius.Length; i++)
            {
                Fahrenheit = (Celsius[i] * 9 / 5) + 32;
                string category;
                if (Celsius[i]   < 15)
                {
                    category = "Cold";
                }
                else if (Celsius[i] <= 30)
                {
                    category = "Warm";
                }
                else
                {
                    category = "Hot";
                }
                Console.WriteLine($"Temperature {i + 1}: {Fahrenheit}°F - {category}");
            }
        }
    }
}
