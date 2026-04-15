using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgram
{
    internal class userDatabase
    {
        //dit is de list voor users
        List<User> users = new List<User>();

        bool validInput = false;

        //in deze functie wordt een user geadd
        public void AddUser(User newUser)
        {
            users.Add(newUser);
        }


        public void RemoveUser()
        {
            validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Input user ID to remove, input CANCEL to return.");
                string removeInput = Console.ReadLine();

                if (int.TryParse(removeInput, out int removeID))
                {
                    if (users.Count < removeID || users.Count == 0)
                    {
                        Console.WriteLine($"\nID does not exist.");
                    }
                    else
                    {
                        users.RemoveAt(removeID);
                        Console.WriteLine($"\nRemoved ID: {removeID}");
                        validInput = true;
                    }
                }
                else if (removeInput == "CANCEL")
                {
                    validInput = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Not a valid ID, try again.");
                    Console.WriteLine(" ");
                }
            }
        }


        public void ViewUser()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("No users found.");
            }
            else if (users.Count > 0)
            {
                if (users.Count == 1)
                {
                    Console.WriteLine("1 user found.");
                }
                else if (users.Count > 1)
                {
                    Console.WriteLine($"{users.Count} users found.");
                }

                for (int i = 0; i < users.Count; i++)
                {
                    User newUser = users[i];

                    Console.WriteLine($"\nUser ID: {i}");
                    Console.WriteLine($"Name: {newUser.Name}");
                    Console.WriteLine($"Email: {newUser.Email}");
                    Console.WriteLine($"Address: {newUser.Address}");
                    Console.WriteLine($"Phonenumber: {newUser.PhoneNumber}");
                    Console.WriteLine($"Age: {newUser.Age}");
                }
            }
        }


        public void EditUser()
        {
            bool validChange = false;
            while (!validChange)
            {
                Console.WriteLine("Input user ID to edit.");
                string editInput = Console.ReadLine();

                if (int.TryParse(editInput, out int editID))
                {
                    if (users.Count < editID || users.Count == 0)
                    {
                        Console.WriteLine($"\nID does not exist.");
                    }
                    else
                    {
                        users.RemoveAt(editID);
                        validChange = true;
                        Console.Clear();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Not a valid ID, try again.");
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
