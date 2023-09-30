using System.Collections.Generic;
using System.Linq;

namespace BookStore.Models.BookRepository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x=> x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorname)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.author.Contains(authorname)).ToList();

        }
        public List<BookModel> DataSource()
        {
            return new List<BookModel>() {
                new BookModel(){Id=1,Title="MVC",author="Abhijeet"},
                new BookModel(){Id=2,Title="core",author="Abhi"},
                new BookModel(){Id=3,Title="C#",author="Abhishek"},
                new BookModel(){Id=4,Title="C++",author="Abhilash"},
                new BookModel(){Id=5,Title="Python",author="Abhir"}



            };
        }
    }
}
