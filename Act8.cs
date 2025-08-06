using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] password = new string[4];
            Console.Write("Enter a password:");

            for (int i = 0;  i < password.Length; i++) {
                Console.Write("password " + (i + 1 )  + ":" );
                password[i] = Console.ReadLine();
                }
            Console.Write("Password Validation:");
            for (int i = 0;i < password.Length; i++)
            {
                string passsword = password[i];
                if (passsword.Length < 8)
                {
                    Console.WriteLine("Password " + (i + 1) + " is too short. It must be at least 8 characters long.");
                }
                else if (!passsword.Any(char.IsUpper))
                {
                    Console.WriteLine("Password " + (i + 1) + " must contain at least one uppercase letter.");
                }
                else if (!passsword.Any(char.IsLower))
                {
                    Console.WriteLine("Password " + (i + 1) + " must contain at least one lowercase letter.");
                }
                else if (!passsword.Any(char.IsDigit))
                {
                    Console.WriteLine("Password " + (i + 1) + " must contain at least one digit.");
                }
                else
                {
                    Console.WriteLine("Password " + (i + 1) + " is valid.");
                }
            }

                


                
            

            }
    }
}
