using BooksClaroDom.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BooksClaroDom.Service.IServices
{
    public interface IBookService
    {
        Task<object> GetPaged(BookFilter filter);
        Task<List<Book>> GetAll();
        Task<Book> GetById(int id);
        Task Save(Book book);
        Task<HttpStatusCode> Delete(int id);
        Task Update(int id);
    }
}
