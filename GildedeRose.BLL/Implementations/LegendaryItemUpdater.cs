using GildedRose.BLL.Interfaces;
using GildedRose.BLL.Items;

namespace GildedRose.BLL.Implementations
{
    public class LegendaryItemUpdater : BaseItemUpdater, IItemUpdater
    {
        public Item UpdateItem(BaseItem legendaryItem)
        {
            DecreaseSellIn(legendaryItem);

            Printer.PrintItem(this.GetType().Name, legendaryItem);

            return legendaryItem;
        }
    }
}
