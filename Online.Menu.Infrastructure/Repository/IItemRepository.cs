using Online.Menu.Core.Models;

namespace Online.Menu.InfraStructure.Repository;

public interface IItemRepository
{
    Task DeleteAsync(int id);
    Task<ItemModel> GetByIdAsync(int id);
    Task<ICollection<ItemModel>> GetAllAsync();
    Task InsertAsync(ItemModel model);
    Task UpdateAsync(ItemModel model);
}
