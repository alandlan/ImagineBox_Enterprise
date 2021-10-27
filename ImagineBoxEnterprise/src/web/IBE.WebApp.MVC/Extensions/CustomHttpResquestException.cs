using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace IBE.WebApp.MVC.Extensions
{
    public class CustomHttpResquestException : Exception
    {
        public HttpStatusCode StatusCode;

        public CustomHttpResquestException()
        {

        }

        public CustomHttpResquestException(string message, Exception innerException) 
            : base (message,innerException)
        {

        }

        public CustomHttpResquestException(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }
    }

    public class CustomPageNotFoundException : Exception
    {
        public HttpStatusCode StatusCode;
        public CustomPageNotFoundException()
        {

        }

        public CustomPageNotFoundException(string message, Exception innerException) : base (message,innerException)
        {

        }

        public CustomPageNotFoundException(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }
    }
}
