using GildedRose.BLL.Helper;

namespace GildedRose.BLL.Items
{
    public class BackStagePassItem : BaseItem
    {
        public BackStagePassItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = ItemHelper.LimitInclusive(quality, 0, 50);
        }
    }
}
