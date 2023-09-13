
namespace SystemSchoolV1.Contracts.Authentication;
public record LoginRequest(
    string Email,
    string Password
);