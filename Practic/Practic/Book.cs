using System;
using System.Collections.Generic;
using System.Text;

namespace Practic
{
    class Book:Product
    {
        public Book(string No, string Name, double Price,string Genre):base(No, Name,Price)
        {
            this.Genre = Genre;
        }
        public string Genre;
    }
}
