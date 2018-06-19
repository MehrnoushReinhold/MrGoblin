using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.BLL.Interfaces;
using GildedRose.BLL.Items;

namespace GildedRose.BLL.Implementations
{
    public class LegendaryItemUpdater : IItemUpdater
    {
        public Item UpdateItem(BaseItem legendaryItem)
        {
            legendaryItem.DecreaseSellIn();

            Printer.PrintItem(this.GetType().Name, legendaryItem);

            return legendaryItem;
        }
    }
}
