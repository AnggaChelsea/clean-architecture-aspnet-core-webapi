using SystemSchoolV1.Application.Common.Interface.Presistence;
using SystemSchoolV1.Domain.Entities;

namespace SystemSchoolV1.Infrastructure.Persistence;


public class SiswaRepository : ISiswaRepository
{
    private static readonly List<Siswa> _siswa = new();
    public void Add(Siswa siswa)
    {
        _siswa.Add(siswa);
    }

    public Siswa? GetSiswaByEmali(string email){
        return _siswa.SingleOrDefault(e => e.Email == email);
    }
}