using AutoMapper;
using Online.Menu.Core.Models;

namespace Online.Menu.Application.Components.Items.Create;

public class CreateItemMapper : Profile
{
    public CreateItemMapper()
    {
        CreateMap<CreateItemParam, ItemModel>();
    }
}
