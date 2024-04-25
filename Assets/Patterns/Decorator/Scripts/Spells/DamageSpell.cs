using Patterns.Decorator.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator.SpellsLogic
{
    public class DamageSpell : Spell
    {
        public int Damage;

        public DamageSpell(Spell spell) : base(spell)
        {
        }

        protected override void ApplySpellToAlive(IAlive aliveTarget)
        {
            Debug.Log($"Damage: {Damage}");
            aliveTarget.HealthSystem.ReceiveDamage(Damage);
        }
    }
}