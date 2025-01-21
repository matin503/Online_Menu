using Microsoft.Extensions.DependencyInjection;
using Online.Menu.Domain;
using Online.Menu.InfraStructure.Framework.Mediators;
using System.Reflection;

namespace Online.Menu.Application;

public static class ApplicationSetup
{
    public static void AddApplicationServices(this IServiceCollection services, Assembly assembly)
    {
        var applicationAssembly = AppDomain.CurrentDomain.Load("Online.Menu.Application");
        services.AddMediatorServices(applicationAssembly);

        services.AddAutoMapper(assembly, applicationAssembly);

        services.AddDomainServices();
    }
}
