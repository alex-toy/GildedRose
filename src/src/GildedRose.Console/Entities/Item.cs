using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public void DecrementQualityByOne()
        {
            this.Quality -= 1;
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
    }
}
