using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.BLL.Items
{
    public class LegendaryItem : BaseItem
    {
        public LegendaryItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }
        public override bool DecreaseSellIn()
        {
            SellIn = SellIn -1;

            return true;
        }

    }
}
