using GildedRose.Console.Entities;

namespace GildedRose.Console.Strategies
{
    public class BonifyingStrategy : Strategy
    {
        public void UpdateQuality(Item item)
        {
            item.IncrementQuality();

            item.SellIn -= 1;

            if (item.SellIn < 0)
            {
                item.IncrementQuality();
            }
        }
    }
}
