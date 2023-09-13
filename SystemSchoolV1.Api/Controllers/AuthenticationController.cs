using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SystemSchoolV1.Contracts.Authentication;

using SystemSchoolV1.Application.Services.AuthenticationService;

namespace SystemSchoolV1.Api.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController : ControllerBase
    {

        private readonly IAuthenticationServices _authenticationService;

        public AuthenticationController(IAuthenticationServices authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest registerRequest)
        {
            var authResult = _authenticationService.Register(
                registerRequest.FirsName,
                registerRequest.LastName,
                registerRequest.Email,
                registerRequest.Password);

            var authenticationResponse = new AuthenticationResponse(
            Guid.NewGuid(),      
            authResult.Siswa.FirsName,   
            authResult.Siswa.LasName,
            authResult.Siswa.Email,
            authResult.Token
            );
            return Ok(authenticationResponse);
        }
        [HttpPost("login")]
        public IActionResult Login(LoginRequest loginRequest)
        {
            var authResult = _authenticationService.Login(
                loginRequest.Email,
                loginRequest.Password);

            var authenticationResponse = new AuthenticationResponse(
            Guid.NewGuid(),       // Id
            authResult.Siswa.FirsName,              // FirstName
            authResult.Siswa.LasName,
            authResult.Siswa.Email,
            authResult.Token    // Token
            );
            return Ok(authenticationResponse);
        }
    }
}