namespace SystemSchoolV1.Domain.Entities;

public class Siswa{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? FirsName { get; set; } = null;
    public string? LasName { get; set; } = null;
    public string? Email { get; set; } = null;
    public string? Password { get; set; } = null;
}