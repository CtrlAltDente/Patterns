using Patterns.Decorator.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator.BuffsLogic
{
    [CreateAssetMenu(fileName = "DamageBuff_", menuName = "ScriptableObjects/Damage Buff", order = 3)]
    public class DamageBuff : Buff
    {
        public int Damage;

        protected override void ApplyBuffToAlive(IAlive aliveTarget)
        {
            aliveTarget.HealthSystem.ReceiveDamage(Damage);
        }
    }
}