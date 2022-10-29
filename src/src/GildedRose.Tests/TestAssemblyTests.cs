using GildedRose.Console;
using GildedRose.Console.Entities;
using NUnit.Framework;
using System.Collections.Generic;

namespace GildedRose.Tests
{
    [TestFixture]
    public class TestAssemblyTests
    {
        private readonly ItemProcessor itemProcessor;

        public TestAssemblyTests()
        {
            itemProcessor = new ItemProcessor();
        }

        [Test]
        public void TestItem1()
        {
            List<Item> Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}
            };
            itemProcessor.Items = Items;

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(9));
            Assert.That(Items[0].Quality, Is.EqualTo(19));
        }

        [Test]
        public void TestItem2()
        {
            List<Item> Items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
            };
            itemProcessor.Items = Items;

            itemProcessor.UpdateQuality();
            Assert.That(Items[0].SellIn, Is.EqualTo(9));
            Assert.That(Items[0].Quality, Is.EqualTo(19));
        }
    }
}