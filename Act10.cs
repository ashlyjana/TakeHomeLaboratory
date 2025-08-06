using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] height = new int[6];
            int ShortCount = 0;
            int AverageCount = 0;
            int TallCount = 0;

           Console.WriteLine("Enter the heights of 6 people in cm:");
            for (int i = 0; i < height.Length; i++)
            {
                Console.Write($"Height of person {i + 1}: ");
                height[i] = int.Parse(Console.ReadLine());
                if (height[i] < 160)
                {
                    ShortCount++;
                }
                else if (height[i] >= 160 && height[i] <= 180)
                {
                    AverageCount++;
                }
                else
                {
                    TallCount++;
                }
            }
            Console.WriteLine($"\nNumber of short people (<160 cm): {ShortCount}");
            Console.WriteLine($"Number of average height people (160-180 cm): {AverageCount}");
            Console.WriteLine($"Number of tall people (>180 cm): {TallCount}");
            Console.ReadKey();
        }
    }
}
