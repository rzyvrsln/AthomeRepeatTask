using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Product
    {
        string _name;
        int _price;

        public string Name 
        { 
            get => _name;
            set { _name.Trim(); _name = value; }
        }
        public int Price 
        { 
            get => _price;
            set { if(value > 0) _price = value; }
        }

    }
}
