using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using gestion.Models;
using gestion.Services;
using Microsoft.AspNetCore.Mvc;

namespace gestion.Controllers.Books
{
    public class BookCreateController  : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookCreateController(IBookRepository bookRepository){
            _bookRepository = bookRepository;
        }
        [HttpPost]
        [Route("api/books/create")]
        public IActionResult Create([FromBody] Book book){
            
            if(book == null)
            {
                return BadRequest("El Objeto libro es nullo");
            }
            _bookRepository.Add(book);
            return Ok(new { message = "El Libro Se Ha Creado Correctamente" });
            
        }
        
    }
}