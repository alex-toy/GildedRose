namespace GildedRose.Console.Entities
{
    public class LegendaryItem : Item
    {
        public override void UpdateQuality()
        {
            DecrementSellIn();
        }
    }
}
