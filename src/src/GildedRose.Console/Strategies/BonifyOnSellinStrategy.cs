using GildedRose.Console.Entities;

namespace GildedRose.Console.Strategies
{
    public class BonifyOnSellinStrategy : Strategy
    {
        public Item Item { get; set; }

        private void BonifyOnSellin()
        {
            Item.IncrementQuality();

            if (Item.SellIn < 11)
            {
                Item.IncrementQuality();
            }

            if (Item.SellIn < 6)
            {
                Item.IncrementQuality();
            }
        }

        public void UpdateQuality()
        {
            BonifyOnSellin();

            Item.SellIn -= 1;

            if (Item.SellIn < 0)
            {
                Item.Quality = 0;
            }
        }
    }
}
