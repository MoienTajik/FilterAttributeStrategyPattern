using System.Net;

namespace SampleWebApp.Models
{
    public class ReturnResult
    {
        public HttpStatusCode StatusCode { get; }

        public ReturnResult(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }
    }
}