using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SystemSchoolV1.Api.Filters;

public class ErrorHandlingFilter : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var exception = context.Exception;

        //back res problems detail
        var problemsDetail = new ProblemDetails{
            Type = "https://tools.ietf.org/html/rfc7231#section-6.6.1",
            Title ="an error occurred while processing your req",
            Status = (int)HttpStatusCode.InternalServerError,
        };

        context.Result = new ObjectResult(problemsDetail);
        context.ExceptionHandled = true;
    }
}