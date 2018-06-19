using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.BLL.Helper;

namespace GildedRose.BLL.Items
{
    public class TheOlderTheBetterItem : BaseItem
    {
        public TheOlderTheBetterItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = ItemHelper.LimitInclusive(quality, 0, 50);
        }
        
        public override bool DecreaseSellIn()
        {
            var reduced = base.DecreaseSellIn();
            if (reduced) { 
                base.IncreaseQuality(1);
                return true;
            }

            return false;
        }
    }
}
