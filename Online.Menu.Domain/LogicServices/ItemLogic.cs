using Online.Menu.Core.Models;
using Online.Menu.InfraStructure.Repository;

namespace Online.Menu.Domain.LogicServices;

internal class ItemLogic(IItemRepository _itemRepository) : AbaseLogic, IItemLogic
{
    public async Task DeleteAsync(int id)
    {
        await _itemRepository.DeleteAsync(id);
    }

    public async Task<ItemModel> GetByIdAsync(int id)
    {
        return await _itemRepository.GetByIdAsync(id);
    }

    public async Task<ICollection<ItemModel>> GetAllAsync()
    {
        return await _itemRepository.GetAllAsync();
    }

    public async Task InsertAsync(ItemModel item)
    {
        await _itemRepository.InsertAsync(item);
    }

    public async Task UpdateAsync(ItemModel item)
    {
        await _itemRepository.UpdateAsync(item);
    }
}
