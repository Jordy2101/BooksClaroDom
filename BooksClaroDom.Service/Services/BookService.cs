using AutoMapper;
using BooksClaroDom.Service.Dto;
using BooksClaroDom.Service.IServices;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BooksClaroDom.Service.Services
{
    public class BookService : IBookService
    {
        public BookService(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Book>> GetAll()
        {
            try
            {
                var apiUrl = Configuration["ApiUrl"];
                var url = apiUrl + $"Books";
                var client = new RestClient(url);
                var getrequest = new RestRequest(Method.GET);
                var response =  client.Execute(getrequest);
                var data = JsonConvert.DeserializeObject<List<Book>>(response.Content);
                return data;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public async Task<Book> GetById(int id)
        {
            try
            {
                var apiUrl = Configuration["ApiUrl"];
                var url = apiUrl + $"Books/{id}";
                var client = new RestClient(url);
                var getrequest = new RestRequest(Method.GET);
                var response = client.Execute(getrequest);
                var data = JsonConvert.DeserializeObject<Book>(response.Content);
                return data;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
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
