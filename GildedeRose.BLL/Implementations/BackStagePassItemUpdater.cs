using GildedRose.BLL.Interfaces;
using GildedRose.BLL.Items;

namespace GildedRose.BLL.Implementations
{
    public class BackStagePassItemUpdater : IItemUpdater
    {
        public Item UpdateItem(BaseItem backStagePass)
        {
            bool reduced = backStagePass.DecreaseSellIn();

            if (reduced) { 
                Printer.PrintItem(this.GetType().Name, backStagePass);
            }

            return backStagePass;
        }
    }
}
