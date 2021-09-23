using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IService.MongoDB;

namespace Jerry.NetCoreDemo.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var books = _bookService.Get();
            return new JsonResult(books);
        }
    }
}
