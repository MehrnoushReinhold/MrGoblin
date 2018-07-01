using GildedRose.BLL.Helper;
using GildedRose.BLL.Interfaces;
using GildedRose.BLL.Items;

namespace GildedRose.BLL.Implementations
{
    public class BackStagePassItemUpdater : BaseItemUpdater, IItemUpdater
    {
        public Item UpdateItem(BaseItem backStagePass)
        {
            bool reduced = DecreaseSellIn(backStagePass);

            if (reduced) { 
                Printer.PrintItem(this.GetType().Name, backStagePass);
            }

            return backStagePass;
        }
        /// <summary>
        /// Decreases the sellin of the item.
        /// Depending on how many days are left before sellin reaches 0. 
        /// The closer to 0 the Sellin gets, the more the quality increases pr. day.
        /// </summary>

        public override bool DecreaseSellIn(BaseItem backStagePass)
        {
            var reduced = base.DecreaseSellIn(backStagePass);
            if (reduced)
            {
                if (backStagePass.SellIn >= 10)
                {
                    base.IncreaseQuality(backStagePass, 1);
                }
                else if (ItemHelper.TestRange(backStagePass.SellIn, 5, 9))
                {
                    //Increase By 2
                    base.IncreaseQuality(backStagePass, 2);
                }
                else if (ItemHelper.TestRange(backStagePass.SellIn, 0, 4))
                {
                    //Increase By 3
                    base.IncreaseQuality(backStagePass, 3);
                }
                else
                {
                    backStagePass.Quality = 0;
                    //Set Quality to 0
                }

                return true;
            }

            return false;
        }

        public virtual void IncreaseQuality(BaseItem backStagePass, int valueToIncreaseBy)
        {
            base.IncreaseQuality(backStagePass, valueToIncreaseBy);
        }

        public virtual void DecreaseQuality(BaseItem backStagePass, int valueToDecreaseBy)
        {
            base.DecreaseQuality(backStagePass, valueToDecreaseBy);
        }
    }
}
