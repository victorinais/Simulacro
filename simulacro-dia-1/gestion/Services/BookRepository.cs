using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gestion.Models;
using gestion.Data;
using gestion.Services;

namespace gestion.Services
{
    public class BookRepository : IBookRepository
    {
        private readonly BaseContext _context;
        public BookRepository(BaseContext context)
        {
            _context = context;
        }
        public void Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = _context.Books.Find(id);
            _context.Books.Remove(book!);
            _context.SaveChanges();
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Books.ToList();
        }

        public Book GetById(int id)
        {
            return _context.Books.Find(id)!;
        }

        public void Update(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }
    }

}