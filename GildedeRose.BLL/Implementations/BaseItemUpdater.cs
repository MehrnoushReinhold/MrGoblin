using GildedRose.BLL.Helper;
using GildedRose.BLL.Interfaces;
using GildedRose.BLL.Items;

namespace GildedRose.BLL.Implementations
{
    public class BaseItemUpdater : IItemUpdater
    {
        /// <summary>
        /// An item 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Item UpdateItem(BaseItem item)
        {
            if (item.IsSellInNonPositiveInteger())
            {
                DecreaseQuality(item, 2);
            }
            else { 
                DecreaseQuality(item, 1);
            }
            DecreaseSellIn(item);


            Printer.PrintItem(this.GetType().Name, item);

            return item;
        }

        public virtual bool DecreaseSellIn(BaseItem item)
        {
            item.SellIn = item.SellIn - 1;
            return true;
        }
        public virtual void IncreaseQuality(BaseItem item, int valueToIncreaseBy)
        {
            item.Quality = ItemHelper.LimitInclusive(item.Quality + valueToIncreaseBy, 0, 50); ;
        }

        public virtual void DecreaseQuality(BaseItem item, int valueToDecreaseBy)
        {
            if (!item.IsQualityZero())
            {

                if (valueToDecreaseBy > item.Quality)
                {
                    item.Quality = 0;
                }
                else
                {
                    item.Quality = item.Quality - valueToDecreaseBy;
                }
            }
        }
    }
}
