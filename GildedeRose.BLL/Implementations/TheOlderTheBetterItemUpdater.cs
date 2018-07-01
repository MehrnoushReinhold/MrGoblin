using GildedRose.BLL.Interfaces;
using GildedRose.BLL.Items;

namespace GildedRose.BLL.Implementations
{
    public class TheOlderTheBetterItemUpdater : BaseItemUpdater, IItemUpdater
    {
        public Item UpdateItem(BaseItem theOlderTheBetter)
        {
            bool reduced = DecreaseSellIn(theOlderTheBetter);

            if (reduced) { 
                Printer.PrintItem(this.GetType().Name, theOlderTheBetter);
            }

            return theOlderTheBetter;
        }

        public override bool DecreaseSellIn(BaseItem item)
        {
            var reduced = base.DecreaseSellIn(item);
            if (reduced)
            {
                base.IncreaseQuality(item, 1);
                return true;
            }

            return false;
        }
    }
}
