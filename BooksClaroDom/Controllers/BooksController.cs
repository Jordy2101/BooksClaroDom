using BooksClaroDom.Attributes;
using BooksClaroDom.Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksClaroDom.Controllers
{
    [ApiKey]
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        readonly IBookService _service;
        public BooksController(IBookService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllBook()
        {
            return Ok(_service.GetAll());
        }

    }
}
