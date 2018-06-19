using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.BLL.Helper;

namespace GildedRose.BLL.Items
{
    public class BackStagePassItem : BaseItem
    {
        public BackStagePassItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = LimitInclusive(quality, 0, 50);
        }

        /// <summary>
        /// Decreases the sellin of the item.
        /// Depending on how many days are left before sellin reaches 0. 
        /// The closer to 0 the Sellin gets, the more the quality increases pr. day.
        /// </summary>
        public override bool DecreaseSellIn()
        {
            var reduced = base.DecreaseSellIn();
            if (reduced)
            {
                if (SellIn >= 10)
                {
                    base.IncreaseQuality(1);
                }
                else if (ItemHelper.TestRange(SellIn, 5, 9))
                {
                    //Increase By 2
                    base.IncreaseQuality(2);
                }
                else if (ItemHelper.TestRange(SellIn, 0, 4))
                {
                    //Increase By 3
                    base.IncreaseQuality(3);
                }
                else
                {
                    Quality = 0;
                    //Set Quality to 0
                }

                return true;
            }

            return false;
        }

        public int LimitInclusive(int value, int min, int max)
        {
            return Math.Min(max, Math.Max(value, min));
        }
    }
}
