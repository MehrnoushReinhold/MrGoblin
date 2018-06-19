using GildedRose.BLL.Interfaces;
using GildedRose.BLL.Items;

namespace GildedRose.BLL.Implementations
{
    public class TheOlderTheBetterItemUpdater : IItemUpdater
    {
        public Item UpdateItem(BaseItem theOlderTheBetter)
        {
            bool reduced = theOlderTheBetter.DecreaseSellIn();

            if (reduced) { 
                Printer.PrintItem(this.GetType().Name, theOlderTheBetter);
            }

            return theOlderTheBetter;
        }
    }
}
