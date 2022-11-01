using GildedRose.Console.Entities;

namespace GildedRose.Console.Strategies
{
    public class RegularStrategy : Strategy
    {
        public Item Item { get; set; }

        public void UpdateQuality()
        {
            Item.DecrementQuality();
            Item.SellIn -= 1;

            if (Item.SellIn < 0) Item.DecrementQuality();
        }
    }
}
