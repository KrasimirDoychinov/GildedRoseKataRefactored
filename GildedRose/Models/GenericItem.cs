using GildedRoseKata;
using GildedRoseKata.Models;

namespace GildedRose.Models
{
    public class GenericItem : Item
    {
        public GenericItem(Item item)
        {
            this.Name = item.Name;
            this.Quality = item.Quality;
            this.SellIn = item.SellIn;
        }

        public virtual void DailyUpdate()
        {
            DailySellInUpdate();
            DailyQualityUpdate();
        }

        protected virtual void DailySellInUpdate()
        {
            this.SellIn--;
        }

        protected virtual void DailyQualityUpdate()
        {
            if (IsExpired())
            {
                DecreaseQuality(2);
                return;
            }
            DecreaseQuality();
        }

        protected virtual bool IsExpired()
        {
            return this.SellIn <= 0;
        }

        protected void DecreaseQuality(int ammount = 1)
        {
            if (this.Quality > 0)
            {
                UpdateQuality(ammount);
            }
        }

        protected virtual void UpdateQuality(int ammount)
        {
            this.Quality = this.Quality - ammount < 0 ? 0 : this.Quality - ammount;
        }
    }
}
