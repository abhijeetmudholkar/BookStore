using BookStore.Models;
using BookStore.Models.BookRepository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        public readonly BookRepository _bookRepository = null;
        public BookController() { 
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data= _bookRepository.GetAllBooks();
            return View();
        }
        public BookModel BookByid(int id)
        {
            return _bookRepository.GetBookById(id);
        }
        public List<BookModel> SearchBook(string bookname,string authorname)
        {
            return _bookRepository.SearchBook(bookname,authorname);
        }
    }
}
