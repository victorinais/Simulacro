using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gestion.Models;

namespace gestion.Services
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();
        Book GetById(int id);
        void Add(Book book);
        void Update(Book book);
        void Delete(int id);
    }
}