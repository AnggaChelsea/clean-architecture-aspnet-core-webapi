using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using SystemSchoolV1.Application.Common.Interface.Presistence;
using SystemSchoolV1.Domain.Entities;

namespace SystemSchoolV1.Application.Common.Interface.Authentication.Commands.Login
{
    public class LoginQueriesHandler : IRequestHandler<LoginQueriesCommands, AuthentiactionResult>
    {
       private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly ISiswaRepository _siswaRepository;

        public LoginQueriesHandler(IJwtTokenGenerator jwtTokenGenerator, ISiswaRepository siswaRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _siswaRepository = siswaRepository;
        }

       async Task<AuthentiactionResult> IRequestHandler<LoginQueriesCommands, AuthentiactionResult>.Handle(LoginQueriesCommands logincommand, CancellationToken cancellationToken)
        {
            if (_siswaRepository.GetSiswaByEmali(logincommand.Email) is not Siswa siswa)
            {
                throw new Exception("Email doesnt exists");
            }
            if (siswa.Password != logincommand.Password)
            {
                throw new Exception("Password does not match with password");
            }

            //create jwt
            var token = _jwtTokenGenerator.GenerateToken(siswa);

            return new AuthentiactionResult(
             siswa,
             token);
        }

       
    }
}