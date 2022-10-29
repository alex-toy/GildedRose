using GildedRose.Console.Entities;

namespace GildedRose.Console
{
    public class ConjuredItem : Item
    {
        public override void UpdateQuality()
        {
            DecrementQuality();

            DecrementSellIn();

            if (SellIn < 0) DecrementQuality();
        }
    }
}