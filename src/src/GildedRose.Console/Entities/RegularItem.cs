using GildedRose.Console.Entities;

namespace GildedRose.Console
{
    public class RegularItem : Item
    {
        public override void UpdateQuality()
        {
            DecrementQuality();

            DecrementSellIn();

            if (SellIn < 0)
            {
                DecrementQuality();
            }
        }
    }
}