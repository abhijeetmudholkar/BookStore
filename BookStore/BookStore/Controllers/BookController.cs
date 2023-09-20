using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "Get All Books";
        }
        public string BookDetails(int id)
        {
            return $"Book Details of id : {id}";
        }
        public string SearchBook(string BookName,string writer)
        {
            return $"Book Name is:{BookName} and writer is :{writer}";
        }
    }
}
