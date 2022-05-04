using GildedRose.Items;
using GildedRoseKata;

namespace GildedRose
{
    public class SulfurasItem : GenericItem
    {
        public SulfurasItem(Item item) 
            : base(item)
        {
        }

        public override void DailyUpdate()
        {
            // Sulfuras item doesn't lose SellIn or Quality
        }
    }
}
