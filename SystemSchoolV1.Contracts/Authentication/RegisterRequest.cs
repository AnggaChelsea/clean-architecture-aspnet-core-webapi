namespace SystemSchoolV1.Contracts.Authentication;

public record RegisterRequest(
    string FirsName,
    string LastName,
    string Email,
    string Password
);