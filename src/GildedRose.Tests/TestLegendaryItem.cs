using GildedRose.BLL.Implementations;
using GildedRose.BLL.Items;
using Xunit;

namespace GildedRose.Tests
{
    public class TestLegendaryItem
    {
        [Fact]
        public void QualityOver50Test()
        {
            var item = new LegendaryItem("Sulfuras, Hand of Ragnaros", 0, 80);

            var updater = new LegendaryItemUpdater();
            
            Assert.Equal(item.Quality, 80);
        }

        [Fact]
        public void QualityDoesNotDecreaseTest()
        {
            var item = new LegendaryItem("Sulfuras, Hand of Ragnaros", 0, 80);

            var updater = new LegendaryItemUpdater();

            for (var i = 0; i < 10; i++)
            {
                updater.UpdateItem((item));
            }

            Assert.Equal(item.Quality, 80);
        }
    }
}