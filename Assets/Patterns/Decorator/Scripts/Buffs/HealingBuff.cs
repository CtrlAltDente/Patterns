using Patterns.Decorator.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator.BuffsLogic
{
    [CreateAssetMenu(fileName = "HealingBuff_", menuName = "ScriptableObjects/Healing Buff", order = 2)]
    public class HealingBuff : Buff
    {
        public int Healing;

        protected override void ApplyBuffToAlive(IAlive aliveTarget)
        {
            aliveTarget.HealthSystem.ReceiveHealing(Healing);
        }
    }
}