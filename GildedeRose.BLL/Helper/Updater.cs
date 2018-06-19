using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.BLL.Implementations;
using GildedRose.BLL.Items;

namespace GildedRose.BLL.Helper
{
    public class Updater
    {
        // Run updater for LegendaryItem.
        public void RunUpdater(LegendaryItem item)
        {
            var updater = new LegendaryItemUpdater();

            updater.UpdateItem(item);
        }

        // Run updater for TheOlderTheBetterItem.
        public void RunUpdater(TheOlderTheBetterItem item)
        {
            var updater = new TheOlderTheBetterItemUpdater();

            updater.UpdateItem(item);
        }

        // Run updater for a general item.
        public void RunUpdater(BaseItem item)
        {
            var updater = new BaseItemUpdater();

            updater.UpdateItem(item);
        }

        // Run updater for conjured item
        public void RunUpdater(ConjuredItem item)
        {
            var updater = new ConjuredItemUpdater();

            updater.UpdateItem(item);
        }

        // Run updater for backStagePass Item
        public void RunUpdater(BackStagePassItem item)
        {
            var updater = new BackStagePassItemUpdater();

            updater.UpdateItem(item);
        }

        // Do nothing if the object is not of any of the above.
        public void RunUpdater(object item)
        {

        }
    }
}
