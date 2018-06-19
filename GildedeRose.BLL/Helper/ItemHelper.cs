using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.BLL.Helper
{
    public static class ItemHelper
    {
        /// <summary>
        /// Test if number to check is within 
        /// </summary>
        /// <param name="numberToCheck"></param>
        /// <param name="bottom"></param>
        /// <param name="top"></param>
        /// <returns></returns>
        public static bool TestRange(int numberToCheck, int min, int max)
        {
            return (numberToCheck >= min && numberToCheck <= max);
        }
        public static int LimitInclusive(int value, int min, int max)
        {
            return Math.Min(max, Math.Max(value, min));
        }
    }
}
