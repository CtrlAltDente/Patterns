using Patterns.IteratorPattern.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.IteratorPattern.Data
{
    public class Item
    {
        public string Name { get; private set; }
        public Quality Quality { get; private set; }

        public Item(string name, Quality quality)
        {
            Name = name;
            Quality = quality;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Quality: {Quality}";
        }
    }
}