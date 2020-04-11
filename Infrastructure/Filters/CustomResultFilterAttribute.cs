using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Filters;
using SampleWebApp.Infrastructure.Formatters;

namespace SampleWebApp.Infrastructure.Filters
{
    public class CustomResultFilterAttribute : ActionFilterAttribute
    {
        private readonly IEnumerable<ResponseFormatter> _responseFormatters;

        public CustomResultFilterAttribute(IEnumerable<ResponseFormatter> responseFormatters)
        {
            _responseFormatters = responseFormatters;
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Type resultType = context.Result.GetType();

            ResponseFormatter appropriateFormatter = _responseFormatters
                .Single(formatter => formatter.ResultTypeToFormat == resultType);

            appropriateFormatter.ContextResult(context);
        }
    }
}