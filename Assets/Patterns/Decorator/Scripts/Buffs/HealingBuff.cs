using Patterns.Decorator.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator.BuffsLogic
{
    public class HealingBuff : Buff
    {
        public int Healing;

        public HealingBuff(int healing)
        {
            Healing = healing;
        }

        protected override void ApplyBuffToAlive(IAlive aliveTarget)
        {
            aliveTarget.HealthSystem.ReceiveHealing(Healing);
        }
    }
}