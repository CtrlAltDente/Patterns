using Patterns.Decorator.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator.SpellsLogic
{
    public class HealingSpell : Spell
    {
        public int Healing;

        public HealingSpell(Spell spell) : base(spell)
        {
        }

        protected override void ApplySpellToAlive(IAlive aliveTarget)
        {
            Debug.Log($"Healing: {Healing}");
            aliveTarget.HealthSystem.ReceiveHealing(Healing);
        }
    }
}