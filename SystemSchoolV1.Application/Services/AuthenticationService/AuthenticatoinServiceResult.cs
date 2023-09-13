using SystemSchoolV1.Domain.Entities;

namespace SystemSchoolV1.Application.Services.AuthenticationService;

public record AuthenticationServiceResult(
    Siswa Siswa,
    string Token
);