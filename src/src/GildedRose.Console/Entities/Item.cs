using System.Linq;

namespace GildedRose.Console.Entities
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public void IncrementQualityByOne()
        {
            this.Quality += 1;
            Quality = Quality > 50 ? 50 : Quality;
        }

        public void DecrementQualityByOne()
        {
            Quality -= 1;
            Quality = Quality < 0 ? 0 : Quality;
        }

        public void ResetQuality()
        {
            this.Quality = 0;
        }

        public void IncrementSellInByOne()
        {
            this.SellIn += 1;
        }

        public void DecrementSellInByOne()
        {
            this.SellIn -= 1;
        }

        public bool IsSpecial()
        {
            string[] specials = { "Aged Brie", "Backstage passes to a TAFKAL80ETC concert", "Sulfuras, Hand of Ragnaros" };
            return specials.Contains(Name);
        }

        public bool Bonifies()
        {
            return Name == "Aged Brie";
        }

        public bool IsLegendary()
        {
            return Name == "Sulfuras, Hand of Ragnaros";
        }

        public bool BonifiesOnSellin()
        {
            return Name == "Backstage passes to a TAFKAL80ETC concert";
        }

        public bool QualityDropsToZeroAfterConcert()
        {
            return Name == "Backstage passes to a TAFKAL80ETC concert";
        }

        public void BonifyOnSellin()
        {
            IncrementQualityByOne();

            if (SellIn < 11)
            {
                IncrementQualityByOne();
            }

            if (SellIn < 6)
            {
                IncrementQualityByOne();
            }
        }

        public void UpdateQuality()
        {
            if (!IsSpecial())
            {
                DecrementQualityByOne();
            }
            else
            {
                if (Bonifies())
                {
                    IncrementQualityByOne();
                }

                if (BonifiesOnSellin())
                {
                    BonifyOnSellin();
                }
            }

            if (!IsLegendary())
            {
                DecrementSellInByOne();
            }

            if (SellIn < 0 && QualityDropsToZeroAfterConcert())
            {
                ResetQuality();
            }

            if (SellIn < 0)
            {
                if (Bonifies())
                {
                    IncrementQualityByOne();
                }

                if (!IsSpecial())
                {
                    DecrementQualityByOne();
                }
            }
        }
    }
}
