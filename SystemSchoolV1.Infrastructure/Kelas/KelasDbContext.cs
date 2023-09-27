using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SystemSchoolV1.Domain.Entities;

namespace SystemSchoolV1.Infrastructure.Kelas
{
    public class KelasDbContext : DbContext
    {
        public KelasDbContext(DbContextOptions<KelasDbContext> options) : base(options)
        {
        }
        public DbSet<KelasModel> KelasModels { get; set; }
    }
}