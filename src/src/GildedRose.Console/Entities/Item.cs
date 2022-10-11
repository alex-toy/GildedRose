namespace GildedRose.Console.Entities
{
    public abstract class Item 
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public abstract void UpdateQuality();

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

        public void ResetQuality()
        {
            this.Quality = 0;
        }

        public void IncrementSellIn()
        {
            this.SellIn += 1;
        }

        public void DecrementSellIn()
        {
            this.SellIn -= 1;
        }
    }
}
