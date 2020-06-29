using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BooksJson.Models;
using System.Data.SqlTypes;

namespace BooksJson.Controllers
{
    public class BooksController : ApiController
    {
        private static List<BooksModel> booksModel = new List<BooksModel>();
        private static List<Books> resultSearch = new List<Books>();
        private static List<Books> books = new List<Books>();

        [HttpGet]
        public List<Books> listBooks()
        {
            string json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Books.json");
            var livro = JsonConvert.DeserializeObject<List<Books>>(json);
            books = livro;
            return books;
        }

        [HttpPost]
        public List<Books> searchBooks(string search)
        {

            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Books.json");
            var livro = JsonConvert.DeserializeObject<List<Books>>(json);
            books = livro;

            resultSearch.Clear();
            foreach(Books find in books)
            {
                if (find.name.Contains(search))
                {
                    resultSearch.Add(find);

                }
                else if (find.price.Equals(search))
                {
                    resultSearch.Add(find);
                }
                else if (find.specifications.author.Contains(search)) 
                {
                    resultSearch.Add(find);
                }
                else if (find.specifications.genres.Contains(search))
                {
                    resultSearch.Add(find);
                }
                else if (find.specifications.illustrator.Contains(search))
                {
                    resultSearch.Add(find);
                }
                
                else if (find.specifications.pageCount.Equals(search))
                {
                    resultSearch.Add(find);
                }
            }
            
            return resultSearch;

        }

        [HttpPost]

        public string freight(string valueBook)
        {

            double freight = Convert.ToDouble(valueBook);
            var total = freight + freight * 0.2;
            freight = freight * 0.2;
            return "O valor do Frete é de: " + freight + "R$, para um livro de "+ valueBook+ "R$, valor total da compra com o frete é " + total+"R$";

        }


 



        }
}
    

