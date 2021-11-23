using AutoMapper;
using BooksClaroDom.Service.Dto;
using BooksClaroDom.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksClaroDom.Service.Services
{
    public class BookService : IBookService
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetPaged()
        {
            throw new NotImplementedException();
        }

        public Task Save(Book book)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
