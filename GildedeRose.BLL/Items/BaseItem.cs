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
