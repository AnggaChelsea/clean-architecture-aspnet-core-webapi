using SystemSchoolV1.Application.Common.Interface.Authentication;
using SystemSchoolV1.Application.Services.AuthenticationService;

namespace SystemSchoolV1.Application.Services.AuthenticationService;

public class AuthenticationService : IAuthenticationServices
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    AuthenticationServiceResult IAuthenticationServices.Register(string FirstName, string LastName, string Email, string Password)
    {
        //if email already exist
       
        //create jwt token
        Guid userId = Guid.NewGuid();
        var token = _jwtTokenGenerator.GenerateToken(userId, FirstName, LastName);

       return new AuthenticationServiceResult(userId, FirstName, LastName, Email, token);
    }

    AuthenticationServiceResult IAuthenticationServices.Login(string Email, string Password)
    {
        return new AuthenticationServiceResult(Guid.NewGuid(), "FirstName", "LastName", Email, "Token");
    }
}