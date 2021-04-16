using SignInAndUp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignInAndUp.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetBooks() 
        {
            List<BookModel> allBooks = new List<BookModel>
            {
                new BookModel
                {
                                PizzaName= "Peri peri",
                                Description = "This is a non veg pizza with chicken on it",
                                PriceofLarge = 335,
                                PriceofMedium = 250,
                                PriceofRegular =150
                }

            };
            return allBooks;
        }

        public BookModel GetBook(int Id)
        {
            BookModel allBooks = new BookModel
            {
                PizzaName = "Peri peri",
                Description = "This is a non veg pizza with chicken on it",
                PriceofLarge = 335,
                PriceofMedium = 250,
                PriceofRegular = 150


            };
            return allBooks;
        }

        public List<BookModel> SearchBooks()
        {
            List<BookModel> allBooks = new List<BookModel>
            {
                new BookModel
                {
                                PizzaName= "Peri peri",
                                Description = "This is a non veg pizza with chicken on it",
                                PriceofLarge = 335,
                                PriceofMedium = 250,
                                PriceofRegular =150
                }

            };
            return allBooks;
        }
    }
}
