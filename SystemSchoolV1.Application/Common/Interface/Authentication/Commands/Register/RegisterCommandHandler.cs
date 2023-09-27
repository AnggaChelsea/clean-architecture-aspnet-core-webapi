using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using SystemSchoolV1.Application.Common.Interface.Presistence;
using SystemSchoolV1.Domain.Entities;

namespace SystemSchoolV1.Application.Common.Interface.Authentication.Commands.Register
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, AuthentiactionResult>
    {

         private readonly IJwtTokenGenerator _jwtTokenGenerator;

        private readonly ISiswaRepository _siswaRepository;
        public RegisterCommandHandler(IJwtTokenGenerator jwtTokenGenerator, ISiswaRepository siswaRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _siswaRepository = siswaRepository;
        }


        async Task<AuthentiactionResult> IRequestHandler<RegisterCommand, AuthentiactionResult>.Handle(RegisterCommand command, CancellationToken cancellationToken)
        {
             if (_siswaRepository.GetSiswaByEmali(command.Email) is not null)
        {
            throw new Exception("User already registered");
        }

        //create user
        var siswa = new Siswa
        {
            FirsName = command.FirsName,
            LasName = command.LasName,
            Email = command.Email,
            Password = command.Password
        };
        //todb
        _siswaRepository.Add(siswa);

        //create jwt token
        // Guid userId = Guid.NewGuid();
        var token = _jwtTokenGenerator.GenerateToken(siswa);
        var res = new {
            Datasiswa = siswa,
            Token = token
        };
        return new AuthentiactionResult(siswa, token);
        }
    }
}