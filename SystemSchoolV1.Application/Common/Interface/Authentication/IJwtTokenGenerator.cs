
namespace SystemSchoolV1.Application.Common.Interface.Authentication;
public interface IJwtTokenGenerator
{
    string GenerateToken(Guid userId, string FirstName, string LastName);
}