using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class User
    {
        string _username;
        string _password;
        bool IsSignedIn;
        Product[] _products;

        public string Username 
        { 
            get => _username;
            set { if (value.Trim().Length > 6 && value.Trim().Length < 25) { _username = value; } }
        }
        public string Password
        { 
            get => _username;
            set { if ( value.Trim().Length > 8 && value.Trim().Length < 25) { _password = value; } }
        }

        public Product[] Products { get => _products; set => _products = value; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            IsSignedIn = true;
        }

        public bool CheckPassword(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i])) { return true; }
                if (Char.IsUpper(password[i])) { return true; }
                if (Char.IsLower(password[i])) { return true; }
            }
            return false;
        }

        public void Login()
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            if (Username == username && Password == password) { IsSignedIn = true; }
        }

        public void Add(Product products)
        {
            if (IsSignedIn) 
            {
                Array.Resize(ref _products, _products.Length + 1);
                _products[_products.Length - 1] = products;
            }
            else { Login(); }
        }


    }
}
