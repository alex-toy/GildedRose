using GildedRose.Console.Entities;

namespace GildedRose.Console
{
    public class BonifyOnSellinItem : Item
    {

        private void BonifyOnSellin()
        {
            IncrementQuality();

            if (SellIn < 11)
            {
                IncrementQuality();
            }

            if (SellIn < 6)
            {
                IncrementQuality();
            }
        }

        public override void UpdateQuality()
        {
            BonifyOnSellin();

            DecrementSellIn();

            if (SellIn < 0)
            {
                Quality = 0;
            }
        }
    }
}