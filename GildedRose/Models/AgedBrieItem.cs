using GildedRoseKata.Models;

namespace GildedRose.Models
{
    public class AgedBrieItem : GenericItem
    {
        public AgedBrieItem(Item item)
            : base(item)
        {
        }

        protected override void DailyQualityUpdate()
        {
            UpdateQuality(1);
        }

        protected override void UpdateQuality(int ammount)
        {
            this.Quality = this.Quality + ammount > 50 ? 50 : this.Quality + ammount;
        }
    }
}
