using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SampleWebApp.Infrastructure.Formatters
{
    public abstract class ResponseFormatter
    {
        public abstract Type ResultTypeToFormat { get; }

        public abstract void ContextResult(ResultExecutingContext context);
    }
}