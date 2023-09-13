namespace SystemSchoolV1.Application.Services.AuthenticationService;

public record AuthenticationServiceResult(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token
);