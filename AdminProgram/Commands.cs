using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdminProgram
{
    internal class Commands
    {
        bool validEmail = false;
        bool ageConfirm = false;

        User user = new User(" ", " ", " ", " ", 0);

        userDatabase database = new userDatabase();
        

        public void AddUser()
        {
            //hier reset ik de values voor deze bools
            validEmail = false;
            ageConfirm = false;

            //In deze functie worden nieuwe users aangemaakt

            //name
            Console.Clear();
            Console.WriteLine("Name:");
            string nameInput = Console.ReadLine();
            user.Name = nameInput;
            Console.Clear();


            //email
            while (!validEmail)
            {
                Console.WriteLine("Email:");
                string emailInput = Console.ReadLine();
                user.Email = emailInput;

                if (emailInput.Contains("@gmail.com"))
                {
                    validEmail = true;
                }

            }


            //address
            Console.Clear();
            Console.WriteLine("Address:");
            Console.WriteLine("Example: Zeemanstraat 28:");
            string AddressInput = Console.ReadLine();
            user.Address = AddressInput;


            Console.Clear();
            Console.WriteLine("Phone number:");
            Console.WriteLine("Example: 06 12345678");
            string PhoneNumberInput = Console.ReadLine();
            user.PhoneNumber = PhoneNumberInput;
            Console.Clear();


            //age
            while (!ageConfirm)
            {
                Console.WriteLine("Age:");
                string ageInput = Console.ReadLine();

                if (int.TryParse(ageInput, out int age))
                {
                    user.Age = age;
                    ageConfirm = true;
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, try again.");
                    Console.WriteLine(" ");
                }
            }


            User newUser = new User(user.Name, user.Email, user.Address, user.PhoneNumber, user.Age);
            database.AddUser(newUser);


            //hier wordt alle informatie geprint
            Console.Clear();
            Console.WriteLine("Name: " + user.Name);
            Console.WriteLine("Email: " + user.Email);
            Console.WriteLine("Address: " + user.Address);
            Console.WriteLine("Phone number: " + user.PhoneNumber);
            Console.WriteLine("Age: " + user.Age);

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }


        public void RemoveUser()
        {
            Console.Clear();
            database.RemoveUser();

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }

        public void ViewUser()
        {
            Console.Clear();
            database.ViewUser();

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }
        
        public void EditUser()
        {
            Console.Clear();
            database.EditUser();
            
            //hier reset ik de values voor deze bools
            validEmail = false;
            ageConfirm = false;

            //In deze functie worden nieuwe users aangemaakt

            //name
            Console.Clear();
            Console.WriteLine("Name:");
            string nameInput = Console.ReadLine();
            user.Name = nameInput;
            Console.Clear();


            //email
            while (!validEmail)
            {
                Console.WriteLine("Email:");
                string emailInput = Console.ReadLine();
                user.Email = emailInput;

                if (emailInput.Contains("@gmail.com"))
                {
                    validEmail = true;
                }

            }


            //address
            Console.Clear();
            Console.WriteLine("Address:");
            Console.WriteLine("Example: Zeemanstraat 28:");
            string AddressInput = Console.ReadLine();
            user.Address = AddressInput;


            Console.Clear();
            Console.WriteLine("Phone number:");
            Console.WriteLine("Example: 06 12345678");
            string PhoneNumberInput = Console.ReadLine();
            user.PhoneNumber = PhoneNumberInput;
            Console.Clear();


            //age
            while (!ageConfirm)
            {
                Console.WriteLine("Age:");
                string ageInput = Console.ReadLine();

                if (int.TryParse(ageInput, out int age))
                {
                    user.Age = age;
                    ageConfirm = true;
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, try again.");
                    Console.WriteLine(" ");
                }
            }


            User newUser = new User(user.Name, user.Email, user.Address, user.PhoneNumber, user.Age);
            database.AddUser(newUser);

            Console.WriteLine("User edited successfully.");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
        }

        public void ExitProgram()
        {
            Environment.Exit(1);
        }
    }
}
