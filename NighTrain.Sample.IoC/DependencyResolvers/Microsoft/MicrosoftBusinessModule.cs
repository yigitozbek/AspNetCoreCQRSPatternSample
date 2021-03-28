using Microsoft.Extensions.DependencyInjection;
using NighTrain.Sample.Data.Repositories.EntityFrameworkCore;
using NighTrain.Sample.Domain.Interfaces;

namespace NighTrain.Sample.IoC.DependencyResolvers.Microsoft
{
    public static class MicrosoftBusinessModule
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
