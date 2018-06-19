using GildedRose.BLL;
using GildedRose.BLL.Items;

namespace GildedRose.BLL.Interfaces
{
    public interface IItemUpdater
    {
        Item UpdateItem(BaseItem item);
    }
}