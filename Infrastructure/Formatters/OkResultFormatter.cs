using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SampleWebApp.Models;

namespace SampleWebApp.Infrastructure.Formatters
{
    public class OkResultFormatter : ResponseFormatter
    {
        public override Type HandlerOf => typeof(OkObjectResult);

        public override void ContextResult(ResultExecutingContext context)
        {
            context.Result = new JsonResult(new ReturnResult(HttpStatusCode.OK));
        }
    }
}