using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemSchoolV1.Domain.Entities
{
    public class KelasModel
    {
        public Guid Id { get; set; }
        public string NamaKelas { get; set; }
        public DateTime JamBuka { get; set; }
        public DateTime JamTutup { get; set; }
    }
}