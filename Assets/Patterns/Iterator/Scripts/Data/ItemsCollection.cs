using Patterns.IteratorPattern.IteratorsLogic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.IteratorPattern.Data
{
    public class ItemsCollection : IteratorAggregate
    {
        private List<Item> _items = new List<Item>();

        public List<Item> Items => _items;

        public void AddItem(Item item)
        {
            if (!_items.Contains(item))
            {
                _items.Add(item);
            }
        }

        public void RemoveItem(Item item)
        {
            if (_items.Contains(item))
            {
                _items.Remove(item);
            }
        }

        public override IEnumerator GetEnumerator()
        {
            return new ItemQualityIterator(this);
        }
    }
}
