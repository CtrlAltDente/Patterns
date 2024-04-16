using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.IteratorPattern.IteratorsLogic
{
    public abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}