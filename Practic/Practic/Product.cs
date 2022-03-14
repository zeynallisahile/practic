using System;
using System.Collections.Generic;
using System.Text;

namespace Practic
{
    class Product
    {
        public Product(string No,string Name, double Price)
        {
            this.No = No;
            this.Name = Name;
            this.Price = Price;
        }

        public string No;
        public string Name;
        public double Price;
        public int Count;
    }
}
