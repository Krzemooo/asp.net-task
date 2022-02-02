using LibApp_Gr3.Data;
using LibApp_Gr3.Interfaces;
using LibApp_Gr3.Models;
using System.Collections.Generic;
using System.Linq;

namespace LibApp_Gr3.Services
{
    public class BookService : IBaseContext<Book>
    {
        protected ApplicationDbContext Context { get; }
        public BookService(ApplicationDbContext context)
        {
            Context = context;
        }
        public Book GetItem(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Book> GetList()
        {
            return Context.Books.ToList();
        }

        public void Insert(Book item)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Book item)
        {
            throw new System.NotImplementedException();
        }
    }
}
