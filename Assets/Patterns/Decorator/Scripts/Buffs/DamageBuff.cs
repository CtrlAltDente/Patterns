using Patterns.Decorator.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator.BuffsLogic
{
    public class DamageBuff : Buff
    {
        public int Damage;

        public DamageBuff(int damage)
        {
            Damage = damage;
        }

        protected override void ApplyBuffToAlive(IAlive aliveTarget)
        {
            aliveTarget.HealthSystem.ReceiveDamage(Damage);
        }
    }
}