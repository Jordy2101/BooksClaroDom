using BooksClaroDom.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksClaroDom.Controllers
{
    [ApiKey]
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
    }
}
