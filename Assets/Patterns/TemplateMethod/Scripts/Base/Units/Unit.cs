using Patterns.TemplateMethod.Base.Attack;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.TemplateMethod.Base.Units
{
    public class Unit : MonoBehaviour
    {
        [SerializeField]
        private Unit _targetUnit;

        private WeaponAttack _weaponAttack;

        private void Awake()
        {
            _weaponAttack = GetComponentInChildren<WeaponAttack>();
        }

        private IEnumerator Start()
        {
            yield return new WaitForSeconds(3f);
            Attack();
        }

        public void Attack()
        {
            _weaponAttack.Attack(_targetUnit);
        }

        public void ReceiveDamage(int damage)
        {
            Debug.Log($"Received damage {damage}");
        }
    }
}