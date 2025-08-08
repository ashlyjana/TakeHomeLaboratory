using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] categories = { "Food", "Rent", "Utilities", "Transport", "Others" };
            double[] expenses = new double[5];
            double monthlyIncome = 25000;
            double total = 0;
            int maxIndex = 0;

            for (int i = 0; i < categories.Length; i++)
            {
                Console.Write($"Enter budget for {categories[i]}: ");
                expenses[i] = double.Parse(Console.ReadLine());
                total += expenses[i];

                if (expenses[i] > expenses[maxIndex])
                {
                    maxIndex = i;
                }
            }

            Console.WriteLine($"\nTotal Budget: {total}");

            if (total > monthlyIncome)
            {
                Console.WriteLine("Over budget!");
                Console.WriteLine($"Suggestion: Reduce expenses in '{categories[maxIndex]}' (Highest expense)");
            }
            else
            {
                Console.WriteLine("Within budget");
            }

        }
    }
}
