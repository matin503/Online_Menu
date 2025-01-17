namespace Online.Menu.Core.Models;

public class ItemModel : AbaseModel
{
    public ICollection<string> ImagePaths { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
   
}
