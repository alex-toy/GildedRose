using GildedRose.Console.Entities;

namespace GildedRose.Console.Strategies
{
    public class BonifyOnSellinStrategy : Strategy
    {
        private void BonifyOnSellin(Item item)
        {
            item.IncrementQuality();

            if (item.SellIn < 11)
            {
                item.IncrementQuality();
            }

            if (item.SellIn < 6)
            {
                item.IncrementQuality();
            }
        }

        public void UpdateQuality(Item item)
        {
            BonifyOnSellin(item);

            item.SellIn -= 1;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }
    }
}
