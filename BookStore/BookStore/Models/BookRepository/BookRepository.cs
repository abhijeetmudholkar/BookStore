using System.Collections.Generic;

namespace BookStore.Models.BookRepository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {

        }
        public BookModel GetBookById(int id)
        {

        }
        public List<BookModel> SearchBook(string title, string authorname)
        {

        }
        public List<BookModel> DataSource()
        {
            return new List<BookModel>() {
                BookModel(){}
            
            
            
            };
        }
    }
}
