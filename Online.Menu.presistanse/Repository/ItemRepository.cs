using Microsoft.EntityFrameworkCore;
using Online.Menu.Core.Models;
using Online.Menu.InfraStructure.Repository;

namespace Online.Menu.presistance.Repository;

internal class ItemRepository(OnlineMenuContext context) : ABaseRepository(context), IItemRepository
{
    public async Task DeleteAsync(int id)
    {
        await _context.Items.Where(x => x.Id == id).ExecuteDeleteAsync(); 
        await _context.SaveChangesAsync();
    }

    public async Task<ICollection<ItemModel>> GetAllAsync()
    {
        return await _context.Items.ToArrayAsync();
    }

    public Task<ItemModel> GetByIdAsync(int id)
    {
        return _context.Items.Where(x=> x.Id == id).FirstOrDefaultAsync();
    }

    public async Task InsertAsync(ItemModel model)
    {
        await _context.Items.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(ItemModel model)
    {
        _context.Items.Update(model);
        await _context.SaveChangesAsync();
    }
}
