﻿using GildedRose.Console.Entities;

namespace GildedRose.Console.Strategies
{
    public class RegularStrategy : Strategy
    {
        public void UpdateQuality(Item item)
        {
            item.DecrementQuality();
            item.SellIn -= 1;

            if (item.SellIn < 0) item.DecrementQuality();
        }
    }
}
