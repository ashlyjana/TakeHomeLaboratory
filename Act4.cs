using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter name no.{0}:", i + 1);
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("Names: ");

            for (int i = 0; i < 3; i++)
            {
                string name = names[i];
                char FirstChar = name[0];
                char LastChar = name[name.Length - 1];

                Console.WriteLine("Name number{0}: {1}", i + 1, name);
                Console.WriteLine("First character:" + FirstChar);
                Console.WriteLine("Last character: " + LastChar);
                Console.WriteLine("First character uppercase: " + FirstChar.ToString().ToUpper());
                Console.WriteLine("Last character uppercase: " + LastChar.ToString().ToUpper());
            }
        }
    }
}
