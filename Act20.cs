using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[5];

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write($"Enter word {i + 1}: ");
                words[i] = Console.ReadLine();
            }

            Console.WriteLine("\nPalindrome Check Results:");
            for (int i = 0; i < words.Length; i++)
            {
                string original = words[i];
                string reversed = "";

                for (int j = original.Length - 1; j >= 0; j--)
                {
                    reversed += original[j];
                }

                if (original.Equals(reversed, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{original} - Palindrome");
                }
                else
                {
                    Console.WriteLine($"{original} - Not a Palindrome");
                }
            }
        }
    }
}
