namespace GildedRose.Console.Entities
{
    public class ConjuredItem : Item
    {
        public override void UpdateQuality()
        {
            DecrementQuality();
            DecrementQuality();

            DecrementSellIn();
        }
    }
}
