using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] months = {
                "January", "February", "March", "April",
                "May", "June", "July", "August",
                "September", "October", "November", "December" };

            float[] sales = new float[12];

            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Enter sales for {months[i]}: ");
                sales[i] = float.Parse(Console.ReadLine());
            }

            float highest = sales[0];
            float lowest = sales[0];
            int highestIndex = 0;
            int lowestIndex = 0;
            float total = 0;

            for (int i = 0; i < 12; i++)
            {
                if (sales[i] > highest)
                {
                    highest = sales[i];
                    highestIndex = i;
                }

                if (sales[i] < lowest)
                {
                    lowest = sales[i];
                    lowestIndex = i;
                }

                total += sales[i];
            }

            float average = total / 12;

            Console.WriteLine($"\nHighest Sales: {months[highestIndex]} - {highest}");
            Console.WriteLine($"Lowest Sales: {months[lowestIndex]} - {lowest}");
            Console.WriteLine($"Average Monthly Sales: {average:F2}");

        }
    }
}
