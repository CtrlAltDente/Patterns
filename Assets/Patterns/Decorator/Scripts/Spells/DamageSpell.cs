using Patterns.Decorator.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator.SpellsLogic
{
    [CreateAssetMenu(fileName = "DamageSpell_", menuName = "ScriptableObjects/Damage Spell", order = 1)]
    public class DamageSpell : Spell
    {
        public int Damage;

        protected override void ApplySpellToAlive(IAlive aliveTarget)
        {
            Debug.Log($"Damage: {Damage}");
            aliveTarget.HealthSystem.ReceiveDamage(Damage);
        }
    }
}