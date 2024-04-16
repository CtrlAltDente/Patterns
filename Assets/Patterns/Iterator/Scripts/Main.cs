using Patterns.IteratorPattern.Data;
using Patterns.IteratorPattern.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.IteratorPattern
{
    public class Main : MonoBehaviour
    {
        public void ShowIteratorPattern()
        {
            ItemsCollection itemsCollection = new ItemsCollection();
            
            itemsCollection.AddItem(new Item("Great sword", Quality.High));
            itemsCollection.AddItem(new Item("Broken pike", Quality.Low));
            itemsCollection.AddItem(new Item("Dragon`s shield", Quality.High));
            itemsCollection.AddItem(new Item("Iron armor", Quality.Standart));
            itemsCollection.AddItem(new Item("Wooden shield ", Quality.Low));
            itemsCollection.AddItem(new Item("Iron shield", Quality.Standart));

            Debug.Log("Foreach list");

            foreach(Item item in itemsCollection.Items)
            {
                Debug.Log(item.ToString());
            }

            Debug.Log("Foreach collection");

            foreach(var item in itemsCollection)
            {
                Debug.Log(item.ToString());
            }
        }
    }
}