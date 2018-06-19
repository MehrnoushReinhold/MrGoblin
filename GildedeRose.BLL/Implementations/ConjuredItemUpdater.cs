using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.BLL.Interfaces;
using GildedRose.BLL.Items;

namespace GildedRose.BLL.Implementations
{
    public class ConjuredItemUpdater : IItemUpdater
    {
        /// <summary>
        /// An item 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Item UpdateItem(BaseItem item)
        {
            if (item.IsSellInNonPositiveInteger())
            {
                item.DecreaseQuality(4);
            }
            else { 
                item.DecreaseQuality(2);
            }
            item.DecreaseSellIn();


            Printer.PrintItem(this.GetType().Name, item);

            return item;
        }
    }
}
