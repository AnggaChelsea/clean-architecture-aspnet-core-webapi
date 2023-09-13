
using Microsoft.Extensions.DependencyInjection;
using SystemSchoolV1.Application.Services.AuthenticationService;

namespace SystemSchoolV1.Application;

public static class DependencyInjection {
    public static IServiceCollection AddApplication(this IServiceCollection services){
    services.AddScoped<IAuthenticationServices, AuthenticationService>();
    return services;
    }
}