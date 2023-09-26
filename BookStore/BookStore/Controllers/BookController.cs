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
        public string SearchBook(string name,string a)
        {
            return $"Book Name is:{name} and writer is :{a}";
        }
    }
}
