using GildedRose.BLL.Implementations;
using GildedRose.BLL.Items;
using Xunit;

namespace GildedRose.Tests
{
    public class TestTheOlderTheBetterItem
    { 
        [Fact]
        public void QualityIncreasesOverTime()
        {
            var startingQuality = 0;
            var item = new TheOlderTheBetterItem("Aged Brie", 2, startingQuality);

            var updater = new TheOlderTheBetterItemUpdater();

            for (var i = 0; i < 50; i++)
            {
                updater.UpdateItem((item));
                startingQuality++;

                Assert.Equal(item.Quality, startingQuality);
            }
        }
    }
}