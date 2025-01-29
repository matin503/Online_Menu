using Online.Menu.InfraStructure.Framework.AppHandlers;
using Online.Menu.Domain.LogicServices;
using AutoMapper;
using SOnline.Menu.InfraStructure.Framework.AppHandlers;
using Online.Menu.Core.Models;

namespace Online.Menu.Application.Components.Items.Create;

internal class CreateItemHandler(IItemLogic _itemLogic, IMapper _mapper) : IHandler<CreateItemParam, IResponse>
{
    public async Task<IResponse> Handle(CreateItemParam itemParam, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<ItemModel>(itemParam);
        
        await _itemLogic.InsertAsync(model);

        return ResponseFactory.Success();
    }
}
