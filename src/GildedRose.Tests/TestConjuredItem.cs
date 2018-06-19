using GildedRose.BLL.Implementations;
using GildedRose.BLL.Items;
using Xunit;

namespace GildedRose.Tests
{
    public class TestConjuredItem
    { 
        [Fact]
        public void QualityDecreasesBy2WhenSellInNotNegative()
        {
            var startingQuality = 20;
            var item = new ConjuredItem("Conjured Mana Cake", 3, startingQuality);

            var updater = new ConjuredItemUpdater();

            for (var i = 0; i < 2; i++)
            {
                updater.UpdateItem((item));
                startingQuality -= 2;

                Assert.Equal(item.Quality, startingQuality);
            }
        }

        [Fact]
        public void QualityDecreasesBy4WhenSellIsNegative()
        {
            var startingQuality = 20;
            var item = new ConjuredItem("Conjured Mana Cake", 0, startingQuality);

            var updater = new ConjuredItemUpdater();

            for (var i = 0; i < 2; i++)
            {
                updater.UpdateItem((item));
                startingQuality -= 4;

                Assert.Equal(item.Quality, startingQuality);
            }
        }
    }
}