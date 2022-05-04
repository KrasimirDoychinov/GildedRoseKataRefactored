using GildedRose.Items;
using GildedRoseKata;

namespace GildedRose
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
