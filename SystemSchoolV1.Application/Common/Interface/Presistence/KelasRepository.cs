using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemSchoolV1.Domain.Entities;

namespace SystemSchoolV1.Application.Common.Interface.Presistence
{
    public interface KelasRepository : IKelasRepository
    {
        void CreateKelas(KelasModel kelasModel);
        KelasModel? GetKelasModel();
    }
}