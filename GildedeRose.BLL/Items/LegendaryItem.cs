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
    }
}
