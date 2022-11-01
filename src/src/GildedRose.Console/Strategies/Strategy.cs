using GildedRose.Console.Entities;

namespace GildedRose.Console.Strategies
{
    public interface Strategy
    {
        Item Item { get; set; }

        void UpdateQuality();
    }
}
