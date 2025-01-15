using MediatR;

namespace Sanpad.Chmlu.MiningLab.InfraStracture.Framework.AppHandlers;

public interface IParam : IRequest
{
}

public interface IParam<T> : IRequest<T>
{
}
