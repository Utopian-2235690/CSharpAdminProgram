using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgram
{
    internal class mainMenu
    {
        public void mainProgram()
        {
            //List<User> _userList = new List<User>();


            User user1 = new User("User", "Example@gmail.com", "Obama 23", "06 5556555", 0);

            bool validEmail = false;

            Console.WriteLine("1 = Add user");
            Console.WriteLine("2 = View user");
            Console.WriteLine("3 = Remove user");
            Console.WriteLine("4 = Edit user");

            string mainMenuInput = Console.ReadLine();


            if (mainMenuInput == "1")
            {
                Console.Clear();
                Console.WriteLine("Name:");
                string nameInput = Console.ReadLine();
                user1.Name = nameInput;

                while (!validEmail)
                {
                    Console.Clear();
                    Console.WriteLine("Email:");
                    string emailInput = Console.ReadLine();
                    user1.Email = emailInput;

                    if (emailInput.Contains("@gmail.com"))
                    {
                        validEmail = true;
                    }
                }

                if (validEmail)
                {
                    Console.Clear();
                    Console.WriteLine("Name: " + user1.Name);
                    Console.WriteLine("Email: " + user1.Email);
                }

            }
        }  
    }
}
