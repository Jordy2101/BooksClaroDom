using BooksClaroDom.Attributes;
using BooksClaroDom.Service.Dto;
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

        [HttpGet]
        [Route("GetByOne/{id}")]
        public IActionResult GetByOne(int id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpGet]
        [Route("GetPaged")]
        public IActionResult GetPaged([FromQuery] BookFilter filter)
        {
            return Ok(_service.GetPaged(filter));
        }
    }
}
