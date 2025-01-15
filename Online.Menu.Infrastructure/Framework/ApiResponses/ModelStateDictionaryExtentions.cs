using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Sanpad.Chmlu.MiningLab.InfraStracture.Framework.ApiResponses;

public static class ModelStateDictionaryExtentions
{
    public static IEnumerable<string> GetErrors(this ModelStateDictionary modelState)
    {
        return modelState.Values.Aggregate(new List<string>(), (a, c) =>
        {
            a.AddRange(c.Errors.Select(r => r.ErrorMessage));
            return a;
        }, a => a);
    }
}
