using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookWorms.BusinessLogic.Abstractions;
using BookWorms.BusinessLogic.DataModel;

namespace BookWorms.DataAccess
{
    public class bookRepository : BaseRepository<Book>, IBookRepository
    {
        public bookRepository(BookWormsDbContext dbContext) : base(dbContext)
        {
        }
        public Book GetBookById(Guid bookId)
        {
            return dbContext.Books
                            .Where(book => book.Id == bookId)
                            .FirstOrDefault();
        }

    }
}
