using GildedRose.BLL;
using GildedRose.BLL.Items;

namespace GildedRose.BLL.Interfaces
{
    public interface IItemUpdater
    {
        Item UpdateItem(BaseItem item);
        bool DecreaseSellIn(BaseItem item);
        void IncreaseQuality(BaseItem item, int valueToIncreaseBy);
        void DecreaseQuality(BaseItem item, int valueToDecreaseBy);
    }
}