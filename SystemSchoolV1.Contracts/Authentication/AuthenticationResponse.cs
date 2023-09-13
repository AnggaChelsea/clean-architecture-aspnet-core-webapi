namespace SystemSchoolV1.Contracts.Authentication;

public record AuthenticationResponse(
    Guid Id,
    string FirsName,
    string LastName,
    string Email,
    string Token
);