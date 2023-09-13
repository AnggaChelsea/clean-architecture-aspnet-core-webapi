
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SystemSchoolV1.Application.Common.Interface.Authentication;
using SystemSchoolV1.Application.Common.Interface.Presistence;
using SystemSchoolV1.Infrastructure.Authentication;
using SystemSchoolV1.Infrastructure.Persistence;

namespace SystemSchoolV1.Infrastructure;

public static class DependencyInjection {
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.Configure<JwtSetting>(configuration.GetSection("JwtSettings"));
        services.AddSingleton<IJwtTokenGenerator, jwtTokenGenerator>();
        services.AddScoped<ISiswaRepository, SiswaRepository>();
    return services;
    }
}