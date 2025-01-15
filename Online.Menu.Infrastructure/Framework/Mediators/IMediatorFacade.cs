namespace Sanpad.Chmlu.MiningLab.InfraStracture.Framework.Mediators;

public interface IMediatorFacade
{
    Task<object> SendAsync<TParam>(TParam param, CancellationToken appStoppingToken);
}
