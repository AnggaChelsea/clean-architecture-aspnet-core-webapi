namespace SystemSchoolV1.Contracts.Kelas;

public record KelasReponse(
    Guid id,
    string NamaKelas,
    DateTime JamBuka,
    DateTime JamTutup
);