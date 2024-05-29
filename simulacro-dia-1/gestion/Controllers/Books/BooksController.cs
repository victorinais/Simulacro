using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gestion.Models;
using gestion.Services;
using Microsoft.AspNetCore.Mvc;

namespace gestion.Controllers.Books
{
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BooksController(IBookRepository bookRepository){
            _bookRepository = bookRepository;
        }

        [HttpGet]
        [Route("api/books")]
        public IEnumerable<Book> GetBooks(){
            return _bookRepository.GetAll();
        }
        [HttpGet]
        [Route("api/books/{id}")]
        public Book Details(int id){
            return _bookRepository.GetById(id);
        }

    }
}