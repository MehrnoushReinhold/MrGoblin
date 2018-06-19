using GildedRose.BLL.Helper;
using GildedRose.BLL.Implementations;
using GildedRose.BLL.Items;
using Xunit;

namespace GildedRose.Tests
{
    public class TestBackStagePassItem
    { 
        [Fact]
        public void QualityIsZeroWhenSellInIsNegative()
        {
            var item = new BackStagePassItem("Backstage passes to a TAFKAL80ETC concert", 15, 20);

            var updater = new BackStagePassItemUpdater();

            for (var i = 0; i < 16; i++)
            {
                updater.UpdateItem(item);
            }

            Assert.Equal(item.Quality, 0);
        }

        [Fact]
        public void QualityIncreasesBy1WhenSellInBiggerThan10()
        {
            var startingQuality = 20;
            var item = new BackStagePassItem("Backstage passes to a TAFKAL80ETC concert", 11, startingQuality);

            var updater = new BackStagePassItemUpdater();

            updater.UpdateItem(item);

            Assert.Equal(item.Quality, startingQuality + 1);
        }

        [Fact]
        public void QualityIncreasesBy2WhenSellInBetween10And6()
        {
            var startingQuality = 20;
            var item = new BackStagePassItem("Backstage passes to a TAFKAL80ETC concert", 9, startingQuality);

            var updater = new BackStagePassItemUpdater();

            updater.UpdateItem(item);

            Assert.Equal(item.Quality, startingQuality+2);
        }

        [Fact]
        public void QualityIncreasesBy3WhenSellInBetween5And1()
        {
            var startingQuality = 20;
            var item = new BackStagePassItem("Backstage passes to a TAFKAL80ETC concert", 1, startingQuality);

            var updater = new BackStagePassItemUpdater();

            updater.UpdateItem(item);

            Assert.Equal(item.Quality, startingQuality + 3);
        }

        [Fact]
        public void TestRangeReturnsTrue()
        {
            var numberToCheck = 8;
            var min = 5;
            var max = 20;

            var item = new BackStagePassItem("Backstage passes to a TAFKAL80ETC concert", 1, 50);

            var result = ItemHelper.TestRange(numberToCheck, min, max);

            Assert.Equal(result, true);

        }

        [Fact]
        public void TestRangeReturnsFalse()
        {
            var numberToCheck = 4;
            var min = 5;
            var max = 20;

            var item = new BackStagePassItem("Backstage passes to a TAFKAL80ETC concert", 1, 50);

            var result = ItemHelper.TestRange(numberToCheck, min, max);

            Assert.Equal(result, false);

        }
    }
}