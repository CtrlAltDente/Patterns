using Patterns.Decorator.BuffsLogic;
using Patterns.Decorator.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator.SpellsLogic
{
    public class Spell
    {
        [SerializeField]
        private List<Buff> Buffs = new List<Buff>();


        [SerializeField]
        protected Spell _spell;

        public Spell()
        {
        }

        public Spell(Spell spell)
        {
            _spell = spell;
        }

        public void AddBuff(Buff buff)
        {
            Buffs.Add(buff);
        }

        public void ApplyToAlive(IAlive aliveTarget)
        {
            ApplySpellToAlive(aliveTarget);
            ApplyBuffToAlive(aliveTarget);

            if(_spell != null)
            {
                _spell.ApplyToAlive(aliveTarget);
                ClearSpell();
            }
        }

        public void ClearSpell()
        {
            _spell = null;
        }

        private void ApplyBuffToAlive(IAlive aliveTarget)
        {
            foreach(Buff buff in Buffs)
            {
                aliveTarget.BuffSystem.AddBuff(buff);
            }
        }

        protected virtual void ApplySpellToAlive(IAlive aliveTarget)
        {
        }
    }
}