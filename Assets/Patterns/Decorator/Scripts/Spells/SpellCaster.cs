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
        private Spell[] _spells;

        [SerializeField]
        private SpellObject _spellObjectPrefab;

        [SerializeField]
        private SpellObject _spellObject;

        private void Start()
        {
            ResetSpell();
        }

        public void ResetSpell()
        {
            if(_spellObject != null)
            {
                Destroy(_spellObject.gameObject);
            }

            _spellObject = null;
            _spellObject = Instantiate(_spellObjectPrefab, Vector3.up, Quaternion.identity);

            foreach(Spell spell in _spells)
            {
                spell.ClearSpell();
            }
        }

        public void AddSpell(Spell spell)
        {
            spell.SetSpell(_spellObject.Spell);
            _spellObject.Spell = spell;
        }

        public void CastTheSpell()
        {
            _spellObject.CastSpellObject(_target);
        }
    }
}