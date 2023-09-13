using SystemSchoolV1.Application.Common.Interface.Authentication;
using SystemSchoolV1.Application.Common.Interface.Presistence;
using SystemSchoolV1.Application.Services.AuthenticationService;
using SystemSchoolV1.Domain.Entities;

namespace SystemSchoolV1.Application.Services.AuthenticationService;

public class AuthenticationService : IAuthenticationServices
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly ISiswaRepository _siswaRepository;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, ISiswaRepository siswaRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _siswaRepository = siswaRepository;

    }

    AuthenticationServiceResult IAuthenticationServices.Register(string FirstName, string LastName, string Email, string Password)
    {
        //validate user doesnt wxist
         if(_siswaRepository.GetSiswaByEmali(Email) is not null){
            throw new Exception("User already registered");
         }

         //create user
         var siswa = new Siswa {
            FirsName = FirstName,
            LasName = LastName,
            Email = Email,
            Password = Password
         };
         //todb
         _siswaRepository.Add(siswa);
       
        //create jwt token
        // Guid userId = Guid.NewGuid();
        var token = _jwtTokenGenerator.GenerateToken(siswa);

       return new AuthenticationServiceResult(siswa, token);
    }

    AuthenticationServiceResult IAuthenticationServices.Login(string Email, string Password)
    {
        // validate email exist
        if(_siswaRepository.GetSiswaByEmali(Email) is not Siswa siswa){
            throw new Exception("Email doesnt exists");
        }
        if(siswa.Password != Password){
            throw new Exception("Password does not match with password");
        }

        //create jwt
        var token = _jwtTokenGenerator.GenerateToken(siswa);
    
        return new AuthenticationServiceResult( 
         siswa,
         token);
    }
}