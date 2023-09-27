using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SystemSchoolV1.Api.Middleware;

public class  ErrorHandlingMiddleware: IFilterMetadata {
    private readonly RequestDelegate _next;

    public ErrorHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context){
        try{
            await _next(context);
        }catch(Exception ex){
             await HandleExceptionAsync(context, ex);
        }
    } 

    private static Task HandleExceptionAsync(HttpContext context, Exception exception){
        var code = HttpStatusCode.InternalServerError; //500
        var result = JsonSerializer.Serialize(new {error = "Error when prosess req"});
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)code;

        return context.Response.WriteAsync(result);
        
    }
}