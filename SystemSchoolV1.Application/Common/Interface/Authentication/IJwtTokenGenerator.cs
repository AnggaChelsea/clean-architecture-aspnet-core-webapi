
using SystemSchoolV1.Domain.Entities;

namespace SystemSchoolV1.Application.Common.Interface.Authentication;
public interface IJwtTokenGenerator
{
    string GenerateToken(Siswa siswa);
}