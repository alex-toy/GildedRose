using GildedRose.Console;
using GildedRose.Console.Entities;
using GildedRose.Console.Strategies;
using NUnit.Framework;
using System.Collections.Generic;

namespace GildedRoseTests
{
    public class Tests
    {
        private ItemProcessor itemProcessor;

        [SetUp]
        public void Setup()
        {
            itemProcessor = new ItemProcessor();
        }

        [Test]
        public void TestItem()
        {
            Item item = new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20, Strategy = new RegularStrategy() };
            item.Strategy.Item = item;

            List<Item> Items = new List<Item> { item };
            itemProcessor.Items = Items;

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(9));
            Assert.That(Items[0].Quality, Is.EqualTo(19));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(8));
            Assert.That(Items[0].Quality, Is.EqualTo(18));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(7));
            Assert.That(Items[0].Quality, Is.EqualTo(17));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(6));
            Assert.That(Items[0].Quality, Is.EqualTo(16));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(5));
            Assert.That(Items[0].Quality, Is.EqualTo(15));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(4));
            Assert.That(Items[0].Quality, Is.EqualTo(14));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(3));
            Assert.That(Items[0].Quality, Is.EqualTo(13));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(2));
            Assert.That(Items[0].Quality, Is.EqualTo(12));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(1));
            Assert.That(Items[0].Quality, Is.EqualTo(11));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(0));
            Assert.That(Items[0].Quality, Is.EqualTo(10));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-1));
            Assert.That(Items[0].Quality, Is.EqualTo(8));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-2));
            Assert.That(Items[0].Quality, Is.EqualTo(6));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-3));
            Assert.That(Items[0].Quality, Is.EqualTo(4));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-4));
            Assert.That(Items[0].Quality, Is.EqualTo(2));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-5));
            Assert.That(Items[0].Quality, Is.EqualTo(0));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-6));
            Assert.That(Items[0].Quality, Is.EqualTo(0));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-7));
            Assert.That(Items[0].Quality, Is.EqualTo(0));
        }

        [Test]
        public void TestRegularItem()
        {
            RegularItem regularItem = new RegularItem
            {
                Name = "Elixir of the Mongoose",
                SellIn = 5,
                Quality = 7,
                Strategy = new RegularStrategy()
            };
            regularItem.Strategy.Item = regularItem;

            List<Item> Items = new List<Item>{  regularItem };
            itemProcessor.Items = Items;

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(4));
            Assert.That(Items[0].Quality, Is.EqualTo(6));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(3));
            Assert.That(Items[0].Quality, Is.EqualTo(5));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(2));
            Assert.That(Items[0].Quality, Is.EqualTo(4));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(1));
            Assert.That(Items[0].Quality, Is.EqualTo(3));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(0));
            Assert.That(Items[0].Quality, Is.EqualTo(2));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-1));
            Assert.That(Items[0].Quality, Is.EqualTo(0));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-2));
            Assert.That(Items[0].Quality, Is.EqualTo(0));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-3));
            Assert.That(Items[0].Quality, Is.EqualTo(0));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-4));
            Assert.That(Items[0].Quality, Is.EqualTo(0));
        }

        [Test]
        public void TestBonifyingItem()
        {
            BonifyingItem bonifyingItem = new BonifyingItem { Name = "Aged Brie", SellIn = 2, Quality = 0, Strategy = new BonifyingStrategy() };
            bonifyingItem.Strategy.Item = bonifyingItem;

            List<Item> Items = new List<Item>
            {
                bonifyingItem
            };
            itemProcessor.Items = Items;

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(1));
            Assert.That(Items[0].Quality, Is.EqualTo(1));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(0));
            Assert.That(Items[0].Quality, Is.EqualTo(2));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-1));
            Assert.That(Items[0].Quality, Is.EqualTo(4));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-2));
            Assert.That(Items[0].Quality, Is.EqualTo(6));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-3));
            Assert.That(Items[0].Quality, Is.EqualTo(8));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-4));
            Assert.That(Items[0].Quality, Is.EqualTo(10));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-5));
            Assert.That(Items[0].Quality, Is.EqualTo(12));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-6));
            Assert.That(Items[0].Quality, Is.EqualTo(14));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-7));
            Assert.That(Items[0].Quality, Is.EqualTo(16));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-8));
            Assert.That(Items[0].Quality, Is.EqualTo(18));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-9));
            Assert.That(Items[0].Quality, Is.EqualTo(20));

            itemProcessor.UpdateQuality();
            itemProcessor.UpdateQuality();
            itemProcessor.UpdateQuality();
            itemProcessor.UpdateQuality();
            itemProcessor.UpdateQuality();
            itemProcessor.UpdateQuality();
            itemProcessor.UpdateQuality();
            itemProcessor.UpdateQuality();
            itemProcessor.UpdateQuality();
            itemProcessor.UpdateQuality();
            itemProcessor.UpdateQuality();
            itemProcessor.UpdateQuality();
            itemProcessor.UpdateQuality();
            itemProcessor.UpdateQuality();
            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-24));
            Assert.That(Items[0].Quality, Is.EqualTo(50));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-25));
            Assert.That(Items[0].Quality, Is.EqualTo(50));
        }

        [Test]
        public void TestLegendaryItem()
        {
            LegendaryItem legendaryItem = new LegendaryItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80, Strategy = new LegendaryStrategy() };
            legendaryItem.Strategy.Item = legendaryItem;
            List<Item> Items = new List<Item>
            {
                legendaryItem
            };
            itemProcessor.Items = Items;

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(0));
            Assert.That(Items[0].Quality, Is.EqualTo(80));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(0));
            Assert.That(Items[0].Quality, Is.EqualTo(80));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(0));
            Assert.That(Items[0].Quality, Is.EqualTo(80));
        }

        [Test]
        public void TestBonifyOnSellinItem()
        {
            BonifyOnSellinItem bonifyOnSellinItem = new BonifyOnSellinItem
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 15,
                Quality = 20,
                Strategy = new BonifyOnSellinStrategy()
            };
            bonifyOnSellinItem.Strategy.Item = bonifyOnSellinItem;

            List<Item> Items = new List<Item>
            {
                bonifyOnSellinItem
            };
            itemProcessor.Items = Items;

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(14));
            Assert.That(Items[0].Quality, Is.EqualTo(21));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(13));
            Assert.That(Items[0].Quality, Is.EqualTo(22));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(12));
            Assert.That(Items[0].Quality, Is.EqualTo(23));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(11));
            Assert.That(Items[0].Quality, Is.EqualTo(24));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(10));
            Assert.That(Items[0].Quality, Is.EqualTo(25));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(9));
            Assert.That(Items[0].Quality, Is.EqualTo(27));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(8));
            Assert.That(Items[0].Quality, Is.EqualTo(29));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(7));
            Assert.That(Items[0].Quality, Is.EqualTo(31));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(6));
            Assert.That(Items[0].Quality, Is.EqualTo(33));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(5));
            Assert.That(Items[0].Quality, Is.EqualTo(35));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(4));
            Assert.That(Items[0].Quality, Is.EqualTo(38));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(3));
            Assert.That(Items[0].Quality, Is.EqualTo(41));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(2));
            Assert.That(Items[0].Quality, Is.EqualTo(44));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(1));
            Assert.That(Items[0].Quality, Is.EqualTo(47));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(0));
            Assert.That(Items[0].Quality, Is.EqualTo(50));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-1));
            Assert.That(Items[0].Quality, Is.EqualTo(0));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-2));
            Assert.That(Items[0].Quality, Is.EqualTo(0));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-3));
            Assert.That(Items[0].Quality, Is.EqualTo(0));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-4));
            Assert.That(Items[0].Quality, Is.EqualTo(0));
        }

        [Test]
        public void TestConjuredItem()
        {
            ConjuredItem conjuredItem = new ConjuredItem { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6, Strategy = new ConjuredStrategy() };
            conjuredItem.Strategy.Item = conjuredItem;

            List<Item> Items = new List<Item>
            {
                conjuredItem
            };
            itemProcessor.Items = Items;

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(2));
            Assert.That(Items[0].Quality, Is.EqualTo(5));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(1));
            Assert.That(Items[0].Quality, Is.EqualTo(4));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(0));
            Assert.That(Items[0].Quality, Is.EqualTo(3));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-1));
            Assert.That(Items[0].Quality, Is.EqualTo(1));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-2));
            Assert.That(Items[0].Quality, Is.EqualTo(0));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-3));
            Assert.That(Items[0].Quality, Is.EqualTo(0));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-4));
            Assert.That(Items[0].Quality, Is.EqualTo(0));

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(-5));
            Assert.That(Items[0].Quality, Is.EqualTo(0));
        }
    }
}