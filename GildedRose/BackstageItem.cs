using GildedRoseKata;

namespace GildedRose.Items
{
    public class BackstageItem : GenericItem
    {
        private int ammount = 1;

        public BackstageItem(Item item) 
            : base(item)
        {
        }

        protected override void DailyQualityUpdate()
        {
            if (IsExpired())
            {
                DropQuality();
                return;
            }
            SetQualityIncreaseAmmount();
            IncreaseQuality(ammount);
        }

        private void DropQuality()
        {
            this.Quality = 0;
        }

        private void SetQualityIncreaseAmmount()
        {
            if (this.SellIn <= 5)
            {
                ammount = 3;
            }
            else if (this.SellIn <= 10)
            {
                ammount = 2;
            }
        }

        protected void IncreaseQuality(int ammount)
        {
            if (this.Quality < 50)
            {
                UpdateQuality(ammount);
            }
        }

        protected override void UpdateQuality(int ammount)
        {
            this.Quality = this.Quality + ammount > 50 ? 50 : this.Quality + ammount;
        }
    }
}
