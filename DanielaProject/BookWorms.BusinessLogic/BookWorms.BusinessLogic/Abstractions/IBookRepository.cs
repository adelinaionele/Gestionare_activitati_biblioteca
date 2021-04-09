using System;
using System.Collections.Generic;
using System.Text;
using BookWorms.BusinessLogic.DataModel;

namespace BookWorms.BusinessLogic.Abstractions
{
    public interface IBookRepository : IRepository<Book>
    {
        Book GetBookById(Guid bookId);
    }
}
