using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SystemSchoolV1.Contracts.Authentication;
using MediatR;
using SystemSchoolV1.Application.Common.Interface.Authentication.Commands.Register;
using SystemSchoolV1.Application.Common.Interface.Authentication.Commands.Login;

namespace SystemSchoolV1.Api.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController : ControllerBase
    {

       private readonly IMediator _imediator;

        public AuthenticationController(IMediator imediator)
        {
            _imediator = imediator;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest registerRequest)
        {
            var command = new RegisterCommand(registerRequest.FirsName, registerRequest.LastName, registerRequest.Email, registerRequest.Password);
            var authResult = _imediator.Send(command);

           
            return Ok(authResult);
        }
        [HttpPost("login")]
        public IActionResult Login(LoginRequest loginRequest)
        {
            var commandLogin = new LoginQueriesCommands(loginRequest.Email, loginRequest.Password);
            var authResult = _imediator.Send(commandLogin);

           
            return Ok(authResult);
        }
    }
}