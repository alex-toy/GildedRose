namespace GildedRose.Console.Entities
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
