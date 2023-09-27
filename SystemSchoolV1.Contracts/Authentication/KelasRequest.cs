using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemSchoolV1.Contracts.Authentication
{
    public record KelasRequest(string NamaKelas, DateTime JamBuka, DateTime JamTutup);
}