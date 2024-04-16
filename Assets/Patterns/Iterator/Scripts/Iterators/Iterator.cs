using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.IteratorPattern.IteratorsLogic
{
    public abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        public abstract int Key();

        public abstract object Current();

        public abstract bool MoveNext();

        public abstract void Reset();
    }

}