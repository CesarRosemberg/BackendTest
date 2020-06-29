using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksJson
{
    public class Books
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public Specifications specifications { get; set; }

       
    }
}