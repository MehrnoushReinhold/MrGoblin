using GildedRose.BLL;
using System.Collections.Generic;
using System.Linq;
using GildedRose.BLL.Helper;
using GildedRose.BLL.Implementations;
using GildedRose.BLL.Items;

namespace GildedRose.Console
{
    class Program
    {

        static List<BaseItem> _items;

        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            _items = new List<BaseItem>
            {
                new BaseItem ("+5 Dexterity Vest", 10, 20),
                new TheOlderTheBetterItem("Aged Brie", 2, 0),
                new BaseItem ("Elixir of the Mongoose", 5, 7),
                new LegendaryItem("Sulfuras, Hand of Ragnaros", 0, 80),
                new BackStagePassItem("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                new ConjuredItem("Conjured Mana Cake", 3,  6)
            };

            UpdateQuality(_items);

            System.Console.ReadKey();
        }
        /// <summary>
        /// Updates and iterates over all items and runs the specific updater based on the item type. 
        /// </summary>
        /// <param name="items"></param>
        public static void UpdateQuality(List<BaseItem> items)
        {
            var updater = new Updater();

            var day = 1;
            // If Quality is 0, we shouldnt run this. Unless the older better item (which is the Brie) since the value increases indefinetely.
            while (items.Any(i => (!(i is TheOlderTheBetterItem) && i.Quality > 0) || (i is TheOlderTheBetterItem && i.Quality < 50)))
            //for (int i = 0; i < 20; i++)
            {
                foreach (var item in items.Where(i => (!(i is TheOlderTheBetterItem) && i.Quality > 0) || (i is TheOlderTheBetterItem && i.Quality < 50)))
                {
                    // Bypass static type checking and let runtime determine which function to call.
                    updater.RunUpdater(((dynamic)item));
                }

                Printer.PrintDay(day);
                day++;
            }
        }

        // Be advised Mr. Goblin. Your class is still here and you can use it as much as you like. I won't however :).
        public class Item
        {
            public string Name { get; set; }

            public int SellIn { get; set; }

            public int Quality { get; set; }
        }
    }
}



