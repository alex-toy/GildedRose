using GildedRose.Console.Entities;

namespace GildedRose.Console.Strategies
{
    public class BonifyingStrategy : Strategy
    {
        public Item Item { get; set; }

        public void UpdateQuality()
        {
            Item.IncrementQuality();

            Item.SellIn -= 1;

            if (Item.SellIn < 0)
            {
                Item.IncrementQuality();
            }
        }
    }
}
