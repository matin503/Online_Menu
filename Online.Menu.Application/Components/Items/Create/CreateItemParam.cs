using Online.Menu.InfraStructure.Framework.AppHandlers;

namespace Online.Menu.Application.Components.Items.Create;

public class CreateItemParam : IParam<IResponse>
{
    public string Title { get; set; }
    public string Description { get; set; }

}
