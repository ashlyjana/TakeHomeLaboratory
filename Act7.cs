using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] votes = new string[10];
            string[] CandidatesNames = new string[10];
            int candidate1Count = 0;
            int candidate2Count = 0;
            int candidate3Count = 0;

            string candidate1 = "Rumi";
            string candidate2 = "Mira";
            string candidate3 = "Zoey";

            Console.WriteLine("Vote for: Rumi, Mira, Zoey");
            Console.WriteLine("Enter 10 votes:");

            for (int i = 0; i < votes.Length; i++)
            {
                string vote = Console.ReadLine();
                CandidatesNames[i] = vote;
                if (vote == candidate1)
                {
                    candidate1Count++;
                }
                else if (vote == candidate2)
                {
                    candidate2Count++;
                }
                else if (vote == candidate3)
                {
                    candidate3Count++;
                }
            }
            Console.WriteLine("Votes for Rumi: " + candidate1Count);
            Console.WriteLine("Votes for Mira: " + candidate2Count);
            Console.WriteLine("Votes for Zoey: " + candidate3Count);

            string winner = "";
            if (candidate1Count > candidate2Count && candidate1Count > candidate3Count)
            {
                winner = candidate1;
            }
            else if (candidate2Count > candidate1Count && candidate2Count > candidate3Count)
            {
                winner = candidate2;
            }
            else if (candidate3Count > candidate1Count && candidate3Count > candidate2Count)
            {
                winner = candidate3;
            }
            else
            {
                winner = "It's a tie!";
            }

            Console.WriteLine("The winner is: " + winner);
            Console.ReadLine();
        
        

        }
    }
}
