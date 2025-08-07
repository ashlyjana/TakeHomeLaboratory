using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] grades = new int[5, 3];  
            int[] totals = new int[5];     
            int[] ranks = new int[5];     
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\nEnter grades for Student {i + 1}:");
                for (int j = 0; j < 3; j++)
                {
                    int grade;
                    do
                    {
                        Console.Write($"  Subject {j + 1} (0-100): ");
                        grade = int.Parse(Console.ReadLine());
                    } while (grade < 0 || grade > 100);

                    grades[i, j] = grade;
                    totals[i] += grade;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                ranks[i] = 1; 
                for (int j = 0; j < 5; j++)
                {
                    if (totals[j] > totals[i])
                    {
                        ranks[i]++;
                    }
                }
            }
            Console.WriteLine("\nStudent\tTotal\tRank");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}\t{totals[i]}\t{ranks[i]}");
            }
        }
    }
}
