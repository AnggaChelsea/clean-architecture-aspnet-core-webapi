using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SystemSchoolV1.Application.Common.Interface.Error;

namespace SystemSchoolV1.Api.Controllers
{
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [Route("/error")]
        public IActionResult Error(){
            Exception? errorExpection = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
            var (statusCode, message) = errorExpection switch {
                DuplicateValue => (StatusCodes.Status409Conflict, "Duplicate value"),
                _ => (StatusCodes.Status500InternalServerError, "an internal error")
            }; 
            return Problem(statusCode: statusCode, title: message);
        }
    }
}