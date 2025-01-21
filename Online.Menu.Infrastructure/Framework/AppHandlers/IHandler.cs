using MediatR;

namespace SOnline.Menu.InfraStructure.Framework.AppHandlers;

public interface IHandler<TParam> : IRequestHandler<TParam> where TParam : IRequest
{
}

public interface IHandler<TParam, TResponse> : IRequestHandler<TParam, TResponse> where TParam : IRequest<TResponse>
{
}
