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
        [Route("GetPaged")]
        public IActionResult GetPaged([FromQuery] BookFilter filter)
        {
            return Ok(_service.GetPaged(filter));
        }

        [HttpGet]
        [Route("GetAllBook")]
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

        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody] Book book)
        {
            return Ok(_service.Save(book));
        }

        [HttpPut]
        [Route("Update/{id}")]
        public IActionResult Update(int id)
        {
            return Ok(_service.Update(id));
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_service.Delete(id));
        }
    }
}
