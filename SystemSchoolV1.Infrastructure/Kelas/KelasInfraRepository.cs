using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemSchoolV1.Application.Common.Interface.Presistence;
using SystemSchoolV1.Domain.Entities;

namespace SystemSchoolV1.Infrastructure.Kelas
{
    public class KelasInfraRepository : IKelasRepository
    {
        //dua
        private readonly KelasDbContext _kelasDbContext;

        public KelasInfraRepository(KelasDbContext kelasDbContext)
        {
            _kelasDbContext = kelasDbContext;
        }
        KelasModel IKelasRepository.CreateKelasModel(KelasModel kelasModel)
        {
            _kelasDbContext.KelasModels.Add(kelasModel);
            _kelasDbContext.SaveChanges();

            return kelasModel;
        }

        List<KelasModel> IKelasRepository.GetKelasModels()
        {
           return _kelasDbContext.KelasModels.ToList();
        }
    }
}