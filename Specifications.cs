using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace BooksJson
{
    public class Specifications
    {
        public string originallyPublished { get; set; }
        public string author { get; set; }
        public int pageCount { get; set; }
        public List<string> illustrator { get; set; }
        public List<string> genres { get; set; }
    }
}