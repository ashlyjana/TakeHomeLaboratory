using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] scores = new float[5];

            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write("Enter the score: ");
                scores[i] = float.Parse(Console.ReadLine()); 
            }

            Console.WriteLine("\nThe results:");

            for (int i = 0; i < scores.Length; i++)
            {
                char grade;

               
                if (scores[i] >= 90)
                    grade = 'A';
                else if (scores[i] >= 80)
                    grade = 'B';
                else if (scores[i] >= 70)
                    grade = 'C';
                else if (scores[i] >= 60)
                    grade = 'D';
                else
                    grade = 'F';

                Console.WriteLine("Score number {0}: {1} --- Grade: {2}", i + 1, scores[i], grade);

                switch (grade)
                {
                    case 'A':
                        Console.WriteLine("Ang Galing!!!!");
                        break;
                    case 'B':
                        Console.WriteLine("Very Good!!!!!!");
                        break;
                    case 'C':
                        Console.WriteLine("Good!!");
                        break;
                    case 'D':
                        Console.WriteLine("Keep it up!(kaya mo yan)");
                        break;
                    case 'F':
                        Console.WriteLine("You failed");
                        break;
                    default:
                        Console.WriteLine("Invalid grade");
                        break;
                }
            }
        }
    }
}
