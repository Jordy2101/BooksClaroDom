using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksClaroDom.Service.Dto
{
    public class Result<T>
    {
        public bool Succeeded { get; set; }
        public string FriendlyMessage { get; set; }
        public T Data { get; set; }
        public string StatusCode { get; set; }
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }

        public static Result<T> Fail(string friendlyMessage, string statusCode, string errorMessage = null, string stackTrace = null)
        {
            return new Result<T>
            {
                Succeeded = false,
                FriendlyMessage = friendlyMessage,
                ErrorMessage = errorMessage,
                StackTrace = stackTrace,
                StatusCode = statusCode
            };
        }

        public static Result<T> Success(T data, string message = null)
        {
            return new Result<T> { Succeeded = true, Data = data, FriendlyMessage = message };
        }
    }
}
