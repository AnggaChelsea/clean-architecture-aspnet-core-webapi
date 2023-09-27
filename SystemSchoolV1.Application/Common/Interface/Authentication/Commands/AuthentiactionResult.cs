using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemSchoolV1.Domain.Entities;

namespace SystemSchoolV1.Application.Common.Interface.Authentication.Commands
{
    public record AuthentiactionResult(Siswa siswa, string token);
}