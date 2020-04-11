using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SampleWebApp.Models;
using System;
using System.Net;

namespace SampleWebApp.Infrastructure.Formatters
{
    public class BadRequestResultFormatter : ResponseFormatter
    {
        public override Type ResultTypeToFormat => typeof(BadRequestObjectResult);

        public override void ContextResult(ResultExecutingContext context)
        {
            // Perform other bad request stuff here ...
            context.Result = new JsonResult(new ReturnResult(HttpStatusCode.BadRequest));
        }
    }
}