using MySharedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_8_23_Assign_23
{
    internal class UserModule
    {
        public static void RegisterUser()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter User Name atleast 5 characters");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter Password atleast 8 characters");
            string password = Console.ReadLine();

            if (DataValidator.ValidateName(name) && DataValidator.ValidateUsername(userName) && DataValidator.ValidatePassword(password))
            {
                Console.WriteLine("User Registered Successfully!");
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("User Registeration");
                UserModule.RegisterUser();

                Console.WriteLine("Do you wish to continue or if yes press 'y' or any other key");
                string choice = Console.ReadLine();
                if (choice == "y")
                {
                    Console.WriteLine("Registration continues");
                }
                else
                {
                    break;
                }

                Console.ReadKey();
            }
        }
    }
}

