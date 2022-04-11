using BookStore.Core.Interfaces;
using BookStore.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookServices _bookServices;
        public BookController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            var response = _bookServices.GetBooks();
            return Ok(response);
        }

        [HttpGet("{id}" , Name ="GetBook")]
        public IActionResult GetBook(string id)
        {
            var response = _bookServices.GetBook(id);
            return Ok(response); 
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            _bookServices.AddBook(book);
            return CreatedAtRoute("GetBook" ,new {id = book.Id}, book); 
        }

        [HttpDelete]
        public IActionResult DeleteBook(string id)
        {
            _bookServices.DeleteBook(id); 
            return NoContent(); 
        }


        [HttpPut]
        public IActionResult UpdateBook(Book book)
        {
            var response = _bookServices.UpdateBook(book);
            return Ok(response); 
        }
    }
}
