using GildedRose.Console.Entities;

namespace GildedRose.Console
{
    public class BonifyingItem : Item
    {
        public override void UpdateQuality()
        {
            IncrementQuality();

            DecrementSellIn();

            if (SellIn < 0)
            {
                IncrementQuality();
            }
        }
    }
}