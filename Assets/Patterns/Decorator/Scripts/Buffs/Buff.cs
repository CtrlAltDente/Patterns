using Patterns.Decorator.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator.BuffsLogic
{
    public abstract class Buff : ScriptableObject
    {
        public int ActiveSeconds;

        public bool IsActive => ActiveSeconds > 0;

        public void UseBuffToAlive(IAlive aliveTarget)
        {
            ApplyBuffToAlive(aliveTarget);
            ActiveSeconds--;
        }

        protected abstract void ApplyBuffToAlive(IAlive aliveTarget);
    }
}