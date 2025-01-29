using Online.Menu.Core.Models;

namespace Online.Menu.Domain.LogicServices;

public interface IItemLogic
{
    Task<ItemModel> GetByIdAsync(int id);
    Task<ICollection<ItemModel>> GetAllAsync();
    Task DeleteAsync(int id);
    Task InsertAsync(ItemModel item);
    Task UpdateAsync(ItemModel item);
}
