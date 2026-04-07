using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgram
{
    internal class Commands
    {
        bool validEmail = false;
        bool ageConfirm = false;

        User user1 = new User("User", "Example@gmail.com", "Example 51", "06 5556555", 0);
        mainMenu MainMenu = new mainMenu();

        public void AddUser()
        {
            //In deze functie worden nieuwe users aangemaakt

            //name
            Console.Clear();
            Console.WriteLine("Name:");
            string nameInput = Console.ReadLine();
            user1.Name = nameInput;
            Console.Clear();


            //email
            while (!validEmail)
            {
                Console.WriteLine("Email:");
                string emailInput = Console.ReadLine();
                user1.Email = emailInput;

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
            user1.Address = AddressInput;
            Console.Clear();

            Console.Clear();
            Console.WriteLine("Phone number:");
            Console.WriteLine("Example: 06 12345678");
            string PhoneNumberInput = Console.ReadLine();
            user1.PhoneNumber = PhoneNumberInput;
            Console.Clear();


            //age
            while (!ageConfirm)
            {
                Console.WriteLine("Age:");
                string ageInput = Console.ReadLine();

                if (int.TryParse(ageInput, out int age))
                {
                    user1.Age = age;
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

            //hier wordt alle informatie geprint
            Console.Clear();
            Console.WriteLine("Name: " + user1.Name);
            Console.WriteLine("Email: " + user1.Email);
            Console.WriteLine("Address: " + user1.Address);
            Console.WriteLine("Phone number: " + user1.PhoneNumber);
            Console.WriteLine("Age: " + user1.Age);

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();

            MainMenu.mainProgram();
        }


        public void RemoveUser()
        {

        }

        public void ViewUser()
        {

        }
        
        public void EditUser()
        {

        }

        public void ExitProgram()
        {
            Environment.Exit(1);
        }
    }
}
