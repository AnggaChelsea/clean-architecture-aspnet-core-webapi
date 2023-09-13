namespace SystemSchoolV1.Application.Services.AuthenticationService;

public interface IAuthenticationServices{
    AuthenticationServiceResult Register(string FirsName, string LasName, string Email, string Password);
    AuthenticationServiceResult Login(string Email, string Password);
}