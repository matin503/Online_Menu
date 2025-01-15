﻿using MediatR;

namespace Sanpad.Chmlu.MiningLab.InfraStracture.Framework.Mediators;

public interface IMediatorService
{
    Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default);
    Task SendAsync<TRequest>(TRequest request, CancellationToken cancellationToken = default) where TRequest : IRequest;
    Task<object> SendAsync(object request, CancellationToken cancellationToken = default);
}
