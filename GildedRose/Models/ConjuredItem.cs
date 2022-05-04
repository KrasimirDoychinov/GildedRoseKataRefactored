using GildedRoseKata.Models;

namespace GildedRose.Models
{
    internal class ConjuredItem : GenericItem
    {
        public ConjuredItem(Item item)
            : base(item)
        {
        }

        protected override void DailyQualityUpdate()
        {
            UpdateQuality(2);
        }

    }
}
