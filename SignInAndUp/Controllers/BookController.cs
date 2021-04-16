using Microsoft.AspNetCore.Mvc;
using SignInAndUp.Models;
using SignInAndUp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignInAndUp.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository=null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public IActionResult Index()
        {

            return View();
        }

        public ViewResult GetBooks() 
        {
           var data=  _bookRepository.GetBooks();
            return View(data);
        
        }

        public ViewResult GetBook(int Id)
        {
            var data =  _bookRepository.GetBook(Id);
            return View(data);

        }
        public List<BookModel> SearchBooks()
        {
            return _bookRepository.SearchBooks();

        }

        
    }
}
