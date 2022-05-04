using GildedRose.Items;
using GildedRoseKata;

namespace GildedRose
{
    public static class GenericItemFactory
    {
        public static GenericItem ParseItem(Item item)
        {
            GenericItem updatedItem;
            switch (item.Name)
            {
                case "Aged Brie":
                    updatedItem = new AgedBrieItem(item);
                    break;
                case string name when name.Contains("Backstage passes"):
                    updatedItem = new BackstageItem(item);
                    break;
                case "Sulfuras, Hand of Ragnaros":
                    updatedItem = new SulfurasItem(item);
                    break;
                case string name when name.Contains("Conjured"):
                    updatedItem = new ConjuredItem(item);
                    break;
                default:
                    updatedItem = new GenericItem(item);
                    break;
            }

            return updatedItem;
        }
    }
}
