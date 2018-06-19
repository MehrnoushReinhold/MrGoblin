using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.BLL.Items;

namespace GildedRose.BLL
{
    public static class Printer
    {
        public static void PrintItem(string updater, Item itemToPrint)
        {
            Console.WriteLine(updater + " updated Name:{0} SellIn {1} Quality {2}.", itemToPrint.Name, itemToPrint.SellIn, itemToPrint.Quality);
        }

        public static void PrintDay(int day)
        {
            Console.WriteLine("************* Day {0} *************", day);
        }
    }
}
