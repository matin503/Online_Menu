using MediatR;

namespace Online.Menu.InfraStructure.Framework.AppHandlers;

public interface IParam : IRequest
{
}

public interface IParam<T> : IRequest<T>
{
}
