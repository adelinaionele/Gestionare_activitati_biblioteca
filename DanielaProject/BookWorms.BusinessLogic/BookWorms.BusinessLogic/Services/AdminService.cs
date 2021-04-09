using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using BookWorms.BusinessLogic.Abstractions;
using BookWorms.BusinessLogic.DataModel;

namespace BookWorms.BusinessLogic.Services
{
    public class AdminService
    {
        IAdminRepository adminRepository;
        IBookRepository bookRepository;

        public AdminService(IAdminRepository adminRepository, IBookRepository bookRepository)
        {
            this.adminRepository = adminRepository;
            this.bookRepository = bookRepository;
        }
        public Admin GetAdminById(Guid Id)
        {
            if (Id == null)
            {
                throw new Exception("Null id");
            }
            return adminRepository.GetAdminById(Id);
        }
        public IEnumerable<Admin> GetAll()
        {
            return adminRepository.GetAll();
        }

        public void AddBook(string userId, string BookDescription, string BookTitle)
        {
            bookRepository.Add(new Book()
            {
                Id = Guid.NewGuid(),
                BookDescription = BookDescription,
                BookTitle = BookTitle,

            });
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return bookRepository.GetAll();
        }
        public Book GetBookById(Guid Id)
        {
            if (Id == null)
            {
                throw new Exception("Null id");
            }
            return bookRepository.GetBookById(Id);
        }
    }
}
