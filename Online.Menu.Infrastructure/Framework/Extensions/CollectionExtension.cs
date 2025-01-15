namespace Sanpad.Chmlu.MiningLab.InfraStracture.Framework.Extensions;

public static class CollectionExtension
{
    public static bool IsNullOrEmpty<T>(this IEnumerable<T> value)
    {
        return value == null || !value.Any();
    }

}
