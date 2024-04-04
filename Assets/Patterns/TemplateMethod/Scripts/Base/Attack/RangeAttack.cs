using Patterns.TemplateMethod.Base.Units;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.TemplateMethod.Base.Attack
{
    public class RangeAttack : WeaponAttack
    {
        [SerializeField]
        private Transform _projectileSpawnPosition;
        [SerializeField]
        private RangeWeaponProjectile _rangeWeaponProjectilePrefab;

        protected override void DoAttackLogic(Unit unit)
        {
            RangeWeaponProjectile weaponProjectile = Instantiate(_rangeWeaponProjectilePrefab, _projectileSpawnPosition.position, Quaternion.identity, null);
            weaponProjectile.FlyToUnit(unit, _damage);
        }
    }
}