using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BookWorms.BusinessLogic.DataModel;

namespace BookWorms.DataAccess
{
    public class BookWormsDbContext : DbContext
    {
        public BookWormsDbContext(DbContextOptions<BookWormsDbContext> options)
            : base(options)
        { }
            public DbSet<Admin> Admins { get; set; }
            public DbSet<Book> Books { get; set; }

    }
}