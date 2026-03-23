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
        User user1 = new User("User", "Example@gmail.com", "Example 51", "06 5556555", 0);
        mainMenu MainMenu = new mainMenu();

        public void AddUser()
        {
            Console.Clear();
            Console.WriteLine("Name:");
            string nameInput = Console.ReadLine();
            user1.Name = nameInput;
            Console.Clear();

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

            Console.Clear();
            Console.WriteLine("Address:");
            string AddressInput = Console.ReadLine();
            user1.Address = AddressInput;
            Console.Clear();

            Console.Clear();
            Console.WriteLine("Phone number:");
            string PhoneNumberInput = Console.ReadLine();
            user1.PhoneNumber = PhoneNumberInput;
            Console.Clear();

            /*Console.Clear();
            Console.WriteLine("Age:");
            string ageInput = Console.ReadLine();
            user1.Age = AgeInput;
            Console.Clear();*/

            //tryparse voor age

            if (validEmail)
            {
                Console.Clear();
                Console.WriteLine("Name: " + user1.Name);
                Console.WriteLine("Email: " + user1.Email);
                Console.WriteLine("Address: " + user1.Address);
                Console.WriteLine("Phone number: " + user1.PhoneNumber);
                //Console.WriteLine("Age: " + user1.Age);

                //Console.Clear();
                //MainMenu.mainProgram();
            }

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
