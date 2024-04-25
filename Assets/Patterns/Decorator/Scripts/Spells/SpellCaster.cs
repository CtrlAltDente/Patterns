using Patterns.Decorator.BuffsLogic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator.SpellsLogic
{
    public class SpellCaster : MonoBehaviour
    {
        [SerializeField]
        private Transform _target;

        [SerializeField]
        private SpellObject _spellObjectPrefab;

        [SerializeField]
        private SpellObject _spellObject;

        private Spell _spell;

        private void Start()
        {
            ResetSpell();
        }

        public void CastTheSpell()
        {
            _spellObject.Spell = _spell;
            _spellObject.CastSpellObject(_target);
            _spellObject.OnDestroyAction += ResetSpell;
        }

        public void ResetSpell()
        {
            if(_spellObject != null)
            {
                Destroy(_spellObject.gameObject);
            }

            _spellObject = null;
            _spellObject = Instantiate(_spellObjectPrefab, Vector3.up, Quaternion.identity);

            _spell = new Spell();
        }

        public void AddDamageSpell(int damage)
        {
            DamageSpell spell = new DamageSpell(_spell);
            spell.Damage = damage;
            _spell = spell;
        }

        public void AddHealingSpell(int healing)
        {
            HealingSpell spell = new HealingSpell(_spell);
            spell.Healing = healing;
            _spell = spell;
        }

        public void AddDamageBuff(int damage)
        {
            _spell.AddBuff(new DamageBuff(damage));
        }

        public void AddHealingBuff(int healing)
        {
            _spell.AddBuff(new HealingBuff(healing));
        }
    }
}