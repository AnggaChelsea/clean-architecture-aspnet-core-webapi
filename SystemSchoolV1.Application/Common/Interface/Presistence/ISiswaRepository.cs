using SystemSchoolV1.Domain.Entities;

namespace SystemSchoolV1.Application.Common.Interface.Presistence;

public interface ISiswaRepository{
    Siswa? GetSiswaByEmali(string email);
    void Add(Siswa siswa);
    
}