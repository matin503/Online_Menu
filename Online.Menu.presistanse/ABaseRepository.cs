using Microsoft.EntityFrameworkCore;

namespace Online.Menu.presistance;

internal abstract class ABaseRepository
{
    public readonly OnlineMenuContext _context;

    protected ABaseRepository(OnlineMenuContext context)
    {
        _context = context;
        _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }
}
