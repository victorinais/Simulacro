using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gestion.Services;
using Microsoft.AspNetCore.Mvc;

namespace gestion.Controllers.Books
{
    public class BookDeleteController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookDeleteController(IBookRepository bookRepository){
            _bookRepository = bookRepository;
        }

        [HttpDelete("{id}")]
        [Route("api/books/{id}/delete")]
        public IActionResult Delete(int id)
        {
            _bookRepository.Delete(id);
            return Ok(new { message = "El Libro Se Ha Eliminado Correctamente" });
        }
    }
}