using Book.Model;
using Book.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        //
        //[HttpGet]
        //public async Task<IEnumerable<Books>> getallbooks()
        //{
        //    return await _bookService.GetBooks();
        //}
        //
        [HttpGet]
        [Route("GetAllBooks")]
        [Produces(typeof(IEnumerable<Books>))]
        public async Task<IActionResult> GetBooks()
        {
            IEnumerable<Books> _books = (IEnumerable<Books>)await _bookService.GetBooks();
            return Ok(_books);
        }
    }   
}
