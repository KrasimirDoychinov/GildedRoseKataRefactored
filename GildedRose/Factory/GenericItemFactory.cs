using GildedRose.Models;
using GildedRoseKata.Models;

namespace GildedRose.Factory
{
    public static class GenericItemFactory
    {
        public static GenericItem ParseItem(Item item)
        {
            GenericItem parsedItem;
            switch (item.Name)
            {
                case "Aged Brie":
                    parsedItem = new AgedBrieItem(item);
                    break;
                case string name when name.Contains("Backstage passes"):
                    parsedItem = new BackstageItem(item);
                    break;
                case "Sulfuras, Hand of Ragnaros":
                    parsedItem = new SulfurasItem(item);
                    break;
                case string name when name.Contains("Conjured"):
                    parsedItem = new ConjuredItem(item);
                    break;
                default:
                    parsedItem = new GenericItem(item);
                    break;
            }

            return parsedItem;
        }
    }
}
