using GildedRose.Console.Strategies;

namespace GildedRose.Console.Entities
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public Strategy Strategy { get; set; }

        public override string ToString()
        {
            return $"Name : '{Name}' - SellIn : {SellIn} - Quality : {Quality}";
        }

        public void UpdateQuality()
        {
            Strategy.UpdateQuality();
        }

        public void IncrementQuality()
        {
            this.Quality += 1;
            Quality = Quality > 50 ? 50 : Quality;
        }

        public void DecrementQuality()
        {
            Quality -= 1;
            Quality = Quality < 0 ? 0 : Quality;
        }
    }
}
