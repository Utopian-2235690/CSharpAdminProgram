using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgram
{
    internal class User
    {

        private string _name;
        private string _email;
        private string _address;
        private string _phoneNumber;
        private int _age;

        public User(string name, string email, string address, string phoneNumber, int age)
        {
            _name = name;
            _email = email;
            _address = address;
            _phoneNumber = phoneNumber;
            _age = age;
        }


        public string Name
        {
            get => _name;

            set
            {
                _name = value;
            }
        }

        public string Email
        {
            get => _email;

            set
            {
                if (value.Contains("@gmail.com"))
                {
                    _email = value;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Email is invalid.");
                    Console.WriteLine("");
                }
            }
        }

        public string Address
        {
            get => _address;

            set
            {
                _address = value;
            }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;

            set
            {
                _phoneNumber = value;
            }
        }

        public int Age
        {
            get => _age;

            set
            {
                _age = value;
            }
        }

    }
}
