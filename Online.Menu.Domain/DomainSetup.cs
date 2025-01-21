using Microsoft.Extensions.DependencyInjection;
using Online.Menu.presistance;

namespace Online.Menu.Domain;

public static class DomainSetup
{
    public static void AddDomainServices(this IServiceCollection services)
    {
        typeof(AbaseLogic)
            .Assembly
            .DefinedTypes
            .Where(dmn => !dmn.IsAbstract && dmn.IsSubclassOf(typeof(AbaseLogic)))
            .ToList()
            .ForEach(dmn =>
            {
                var idmn = dmn.GetInterface($"I{dmn.Name}");
                services.AddTransient(idmn, dmn);
            });
        services.AddPersistance();
    }
}
