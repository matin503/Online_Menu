namespace Online.Menu.InfraStructure.Framework.Mediators;

public interface IMediatorFacade
{
    Task<object> SendAsync<TParam>(TParam param, CancellationToken appStoppingToken);
}
