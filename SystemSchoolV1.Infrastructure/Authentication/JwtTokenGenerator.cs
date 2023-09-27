
using System.IdentityModel.Tokens.Jwt;
using System.Security.AccessControl;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SystemSchoolV1.Application.Common.Interface.Authentication;
using SystemSchoolV1.Domain.Entities;

namespace SystemSchoolV1.Infrastructure.Authentication;

public class jwtTokenGenerator : IJwtTokenGenerator
{

    private readonly JwtSetting _jwtSetting;

    public jwtTokenGenerator(IOptions<JwtSetting> jwtSettingOptions)
    {
        _jwtSetting = jwtSettingOptions.Value;
    }

    public string GenerateToken(Siswa siswa)
    {
        var signingCredential = new SigningCredentials(
            new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes("this is my custom Secret key for authenticationasdasdasdasdasdasdasdasdasdasd")
            ),
            SecurityAlgorithms.HmacSha256
        );
        var claims = new [] 
        {
            new Claim(JwtRegisteredClaimNames.Sub, siswa.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName, siswa.FirsName),
            new Claim(JwtRegisteredClaimNames.FamilyName, siswa.LasName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        };

        var securityToken = new JwtSecurityToken(
            issuer: _jwtSetting.Issuer,
            expires: DateTime.Now.AddDays(1),
            claims: claims,
            signingCredentials: signingCredential
            );

        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }
}