using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.BLL.Helper;

namespace GildedRose.BLL.Items
{
    public class ConjuredItem : BaseItem
    {
        public ConjuredItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = ItemHelper.LimitInclusive(quality, 0, 50);
        }
    }
}
