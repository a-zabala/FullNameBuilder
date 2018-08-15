using System;
using System.Text;

namespace FullNameBuilder
{
   
    
        class Program
        {
            static void Main(string[] args)
            {
                //Prompts for user input of first name, then stores it
                Console.Write("Please enter your first name: ");
                string firstName = Console.ReadLine();
                //Prompts for user input of last name, then stores it
                Console.Write("Please enter your last name: ");
                string lastName = Console.ReadLine();
                //uses method to combine names and prints
                Console.WriteLine(FullName(firstName, lastName));
                Console.ReadLine();
            }

            /// <summary>
            /// Combines first and last name into one string called fullName using String Builder
            /// </summary>
            /// <param name="firstName"></param>
            /// <param name="lastName"></param>
            /// <returns>fullName</returns>
            private static StringBuilder FullName(string firstName, string lastName)
            {
            StringBuilder fullName = new StringBuilder();
            fullName.Append(firstName);
            fullName.Append(" ");
            fullName.Append(lastName);
                return fullName;

            }
        }
    }

