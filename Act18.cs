using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] passwords = new string[5];

            for (int i = 0; i < passwords.Length; i++)
            {
                Console.Write($"Enter password {i + 1}: ");
                passwords[i] = Console.ReadLine();
            }

            Console.WriteLine("Password Strength Results:");

            for (int i = 0; i < passwords.Length; i++)
            {
                string pwd = passwords[i];
                bool hasUpper = false, hasDigit = false, hasSpecial = false;

                for (int j = 0; j < pwd.Length; j++)
                {
                    char c = pwd[j];
                    if (char.IsUpper(c))
                        hasUpper = true;
                    else if (char.IsDigit(c))
                        hasDigit = true;
                    else if ("!@#$%^&*()_+=-[]{};:'\",.<>?/\\|".Contains(c))
                        hasSpecial = true;
                }

                if (pwd.Length >= 8)
                {
                    if (hasUpper)
                    {
                        if (hasDigit)
                        {
                            if (hasSpecial)
                            {
                                Console.WriteLine($"Password {i + 1}: Strong");
                            }
                            else
                            {
                                Console.WriteLine($"Password {i + 1}: Weak (No special character)");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Password {i + 1}: Weak (No digit)");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Password {i + 1}: Weak (No uppercase letter)");
                    }
                }
                else
                {
                    Console.WriteLine($"Password {i + 1}: Invalid (Too short)");
                }
            }
        }
    }
}
