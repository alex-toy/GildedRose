using GildedRose.Console.Entities;
using System.Collections.Generic;
using System;

namespace GildedRose.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            List<Item> Items = new List<Item>
            {
                new RegularItem {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new BonifyingItem {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new RegularItem {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new LegendaryItem {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new BonifyOnSellinItem
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new ConjuredItem {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            var itemProcessor = new ItemProcessor()
            {
                Items = Items
            };

            itemProcessor.UpdateQuality();

            System.Console.WriteLine(itemProcessor.Items[0]);

            System.Console.ReadKey();

        }
    }
}