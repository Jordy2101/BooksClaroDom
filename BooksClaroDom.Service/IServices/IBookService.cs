using BooksClaroDom.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksClaroDom.Service.IServices
{
    public interface IBookService
    {
        Task<object> GetPaged();
        Task<List<Book>> GetAll();
        Task<Book> GetById(int id);
        Task Save(Book book);
        Task Delete(int id);
        Task Update(int id);
    }
}
