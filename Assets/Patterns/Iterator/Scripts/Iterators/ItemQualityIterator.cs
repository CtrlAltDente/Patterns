using Patterns.IteratorPattern.Data;
using Patterns.IteratorPattern.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.IteratorPattern.IteratorsLogic
{
    public class ItemQualityIterator : Iterator
    {
        private int _point = -1;

        private List<Item> _items = new List<Item>();

        public ItemQualityIterator(ItemsCollection itemsCollection)
        {
            AddItemsByQuality(itemsCollection.Items, Quality.Low);
            AddItemsByQuality(itemsCollection.Items, Quality.Standart);
            AddItemsByQuality(itemsCollection.Items, Quality.High);
        }

        public override object Current()
        {
            return _items[_point];
        }

        public override int Key()
        {
            return _point;
        }

        public override bool MoveNext()
        {
            if (_point + 1 < _items.Count)
            {
                _point++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            _point = 0;
        }

        private void AddItemsByQuality(List<Item> items,Quality quality)
        {
            foreach(Item item in items)
            {
                if (item.Quality == quality)
                {
                    _items.Add(item);
                }
            }
        }
    }
}