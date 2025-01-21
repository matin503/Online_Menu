namespace Online.Menu.InfraStructure.Framework.AppHandlers;

public interface IResponsePagination
{
    Status Status { get; }

    IEnumerable<string> Messages { get; }
}

public interface IResponsePagination<out T> : IResponsePagination
{
    T Data { get; }

    int TotalItems { get; }
}
