using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] symptoms = new string[5];

            for (int i = 0; i < symptoms.Length; i++)
            {
                Console.WriteLine("Enter symptom " + (i + 1) + ":");
                symptoms[i] = Console.ReadLine().ToLower();
            }

            Console.WriteLine("You have entered the following symptoms:");

            for (int i = 0; i < symptoms.Length; i++)
            {
                Console.WriteLine(symptoms[i]);

                string department;

                switch (symptoms[i])
                {
                    case "fever":
                        department = "General Medicine";
                        break;
                    case "cough":
                        department = "General Medicine";
                        break;
                    case "injury":
                        department = "Emergency";
                        break;
                    case "burn":
                        department = "Emergency";
                        break;
                    default:
                        department = "Refer to Specialist";
                        break;
                }

                Console.WriteLine($"Patient {i + 1} ({symptoms[i]}) belongs to  {department}");
            }
        }
    }
}
