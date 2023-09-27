using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemSchoolV1.Contracts.Kelas
{
   public record KelasRequest(string NameKelas, DateTime JamBuka, DateTime JamTutup);
}