using SystemSchoolV1.Application;
using SystemSchoolV1.Infrastructure;
using SystemSchoolV1.Api.Middleware;
using SystemSchoolV1.Api.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using SystemSchoolV1.Api.Errors;
using SystemSchoolV1.Application.Common.Interface.Presistence;
using SystemSchoolV1.Infrastructure.Kelas;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
{

    ConfigurationManager configuration = builder.Configuration;

    //add database servcies
    builder.Services.AddDbContext<KelasDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultString"),
    o => o.MigrationsAssembly("SystemSchoolV1.Api")
    ));

    builder.Services.AddScoped<IKelasRepository, KelasInfraRepository>();
    builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);
    builder.Services.AddControllers();
    // builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlingMiddleware>());
    builder.Services.AddSingleton<ProblemDetailsFactory, SystemSchoolProbelmFactory>();
}
// Add services to the container.
var app = builder.Build();
{
    // app.UseMiddleware<ErrorHandlingMiddleware>();
    // app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}



