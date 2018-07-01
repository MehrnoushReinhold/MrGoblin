using GildedRose.BLL.Helper;
using GildedRose.BLL.Implementations;
using GildedRose.BLL.Items;
using Xunit;

namespace GildedRose.Tests
{
    public class TestBaseItem
    {
        [Fact]
        public void DecreaseSellIn()
        {
            var baseItem = new BaseItem("Base name", 0, 50);
            BaseItemUpdater baseItemUpdater = new BaseItemUpdater();
            baseItemUpdater.DecreaseSellIn(baseItem);

            Assert.Equal(baseItem.SellIn, -1);
        }

        [Fact]
        public void IncreaseQuality()
        {
            var baseItem = new BaseItem("Base name", 0, 30);

            var value = 5;
            BaseItemUpdater baseItemUpdater = new BaseItemUpdater();
            baseItemUpdater.IncreaseQuality(baseItem, value);

            Assert.Equal(baseItem.Quality, 35);
        }

        [Fact]
        public void DecreaseQuality()
        {
            var baseItem = new BaseItem("Base name", 0, 40);
            var value = 19;
            BaseItemUpdater baseItemUpdater = new BaseItemUpdater();
            baseItemUpdater.DecreaseQuality(baseItem, value);

            Assert.Equal(baseItem.Quality, 21);

        }

        [Fact]
        public void IsSellInNonPositiveInteger()
        {
            var baseItem = new BaseItem("Base name", 0, 30);

            var result = baseItem.IsSellInNonPositiveInteger();

            Assert.Equal(result, true);
        }

        [Fact]
        public void IsSellInNonPositiveIntegerReturnsFalse()
        {
            var baseItem = new BaseItem("Base name", 2, 30);

            var result = baseItem.IsSellInNonPositiveInteger();

            Assert.Equal(result, false);
        }

        [Fact]
        public void IsQualityZero()
        {
            var baseItem = new BaseItem("Base name", 0, 50);

            var result = baseItem.IsQualityZero();

            Assert.Equal(result, false);
        }

        [Fact]
        public void LimitInclusive()
        {
            var baseItem = new BaseItem("Base name", 0, 50);

            var value = 4;
            var min = 5;
            var max = 15;
            
            var result = ItemHelper.LimitInclusive(value, min, max);

            Assert.Equal(result, 5);

        }


        [Fact]
        public void UpperInclusive()
        {
            var baseItem = new BaseItem("Base name", 0, 50);

            var value = 17;
            var min = 5;
            var max = 15;

            var result = ItemHelper.LimitInclusive(value, min, max);

            Assert.Equal(result, 15);

        }
    }
}