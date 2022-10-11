namespace GildedRose.Console.Entities
{
    public class BonifyOnSellinItem : Item
    {

        private void BonifyOnSellin()
        {
            IncrementQuality();

            if (SellIn < 11)
            {
                IncrementQuality();
            }

            if (SellIn < 6)
            {
                IncrementQuality();
            }
        }

        public override void UpdateQuality()
        {
            BonifyOnSellin();

            DecrementSellIn();

            if (SellIn < 0)
            {
                IncrementQuality();
            }
        }
    }
}
