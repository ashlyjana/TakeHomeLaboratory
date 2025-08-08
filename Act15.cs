using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userNumbers = new int[20]; 
            int[] winningNumbers = { 7, 13, 25, 42, 58, 77 }; 

            for (int i = 0; i < 20; i++)
            {
                int number;
                for (; ; )
                {
                    Console.Write($"User {i + 1}, enter your lucky number (1–99): ");
                    number = int.Parse(Console.ReadLine());

                    if (number >= 1 && number <= 99)
                    {
                        userNumbers[i] = number;
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Invalid!");
                    }
                }
            }
            Console.WriteLine("Lucky Draw Results:");
            for (int i = 0; i < 20; i++)
            {
                bool isWinner = false;

                for (int j = 0; j < winningNumbers.Length; j++)
                {
                    if (userNumbers[i] == winningNumbers[j])
                    {
                        isWinner = true;
                        break;
                    }
                }

                if (isWinner)
                {
                    Console.WriteLine($"Congratulations User {i + 1}! {userNumbers[i]} is a WINNING number!");
                }
                else
                {
                    Console.WriteLine($"User {i + 1}: {userNumbers[i]} did not win");
                }
            }
        }
    }
}
