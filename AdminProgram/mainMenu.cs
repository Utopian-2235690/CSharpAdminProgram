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
            bool validInput = false;
            Commands commands = new Commands();

            Console.Clear();
            Console.WriteLine("1 = Add user");
            Console.WriteLine("2 = Remove user");
            Console.WriteLine("3 = View user");
            Console.WriteLine("4 = Edit user");
            Console.WriteLine("5 = Exit program");

 
            while (!validInput)
            {
                string mainMenuInput = Console.ReadLine();


                if (mainMenuInput == "1")
                {
                    commands.AddUser();
                }

                else if (mainMenuInput == "2")
                {
                    commands.RemoveUser();
                }

                else if (mainMenuInput == "3")
                {
                    commands.ViewUser();
                }

                else if (mainMenuInput == "4")
                {
                    commands.EditUser();
                }

                else if (mainMenuInput == "5")
                {
                    commands.ExitProgram();
                }
            }
        }  
    }
}
