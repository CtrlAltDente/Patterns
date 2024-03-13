using Patterns.Decorator.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator.SpellsLogic
{
    [CreateAssetMenu(fileName = "HealingSpell_", menuName = "ScriptableObjects/Healing Spell", order = 0)]
    public class HealingSpell : Spell
    {
        public int Healing;

        protected override void ApplySpellToAlive(IAlive aliveTarget)
        {
            Debug.Log($"Healing: {Healing}");
            aliveTarget.HealthSystem.ReceiveHealing(Healing);
        }
    }
}