namespace Online.Menu.Core.Models;

public abstract class AbaseModel
{
    public int Id { get; set; }
    public DateTime UpdateTime { get; set; }
    public DateTime CreateTime { get; set; }

}
