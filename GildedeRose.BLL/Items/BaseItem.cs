using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.BLL.Helper;

namespace GildedRose.BLL.Items
{
    public class BaseItem : Item
    {
        public BaseItem(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = ItemHelper.LimitInclusive(quality, 0, 50);
        }

        public virtual bool DecreaseSellIn()
        {
            SellIn = SellIn - 1;
            return true;
        }
        public void IncreaseQuality(int valueToIncreaseBy)
        {
            Quality = ItemHelper.LimitInclusive(Quality + valueToIncreaseBy, 0, 50); ;
        }

        public void DecreaseQuality(int valueToDecreaseBy)
        {
            if (!IsQualityZero())
            {

                if (valueToDecreaseBy > Quality)
                {
                    Quality = 0;
                }
                else
                {
                    Quality = Quality - valueToDecreaseBy;
                }
            }
        }

        public bool IsSellInNonPositiveInteger()
        {
            return SellIn <= 0;
        }

        public bool IsQualityZero()
        {
            return Quality == 0;
        }
    }
}
