using GildedRose;
using GildedRose.Factory;
using GildedRose.Models;
using GildedRoseKata.Models;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        private IList<Item> items;

        public GildedRose(IList<Item> Items)
        {
            this.items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < items.Count; i++)
            {
                var parsedItem = GenericItemFactory.ParseItem(items[i]);
                parsedItem.DailyUpdate();
                UpdateActualItem(i, parsedItem);
            }
        }

        private void UpdateActualItem(int i, GenericItem parsedItem)
        {
            items[i] = parsedItem;
        }
    }
}
