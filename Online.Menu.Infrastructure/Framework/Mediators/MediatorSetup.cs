using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Sanpad.Chmlu.MiningLab.InfraStracture.Framework.Mediators;

public static class MediatorSetup
{
    public static void AddMediatorServices(this IServiceCollection services, Assembly assembly)
    {
        services.AddTransient<IMediatorFacade, MediatorFacade>();
        services.AddTransient<IMediatorService, MediatorService>();

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

    }
}
