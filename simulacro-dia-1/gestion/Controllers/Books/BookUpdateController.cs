using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gestion.Models;
using gestion.Services;
using Microsoft.AspNetCore.Mvc;

namespace gestion.Controllers.Books
{
    public class BookUpdateController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookUpdateController(IBookRepository bookRepository){
            _bookRepository = bookRepository;
        }

        [HttpPut("{id}")]
        [Route("api/books/{id}/update")]
        public IActionResult Update(int id, [FromBody] Book book)
        {
            if(book == null)
            {
                return BadRequest("El Objeto libro es nullo");
            }
            _bookRepository.Update(book);
            return Ok(new { message = "El Libro Se Ha Actualizado Correctamente" });
        }
    }
}