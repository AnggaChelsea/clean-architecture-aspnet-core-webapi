using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemSchoolV1.Domain.Entities;

namespace SystemSchoolV1.Application.Common.Interface.Presistence
{
    public interface IKelasRepository
    {
        List<KelasModel> GetKelasModels();
        KelasModel CreateKelasModel(KelasModel kelasModel);
    }
}