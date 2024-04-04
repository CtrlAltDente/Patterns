using Patterns.TemplateMethod.Base.Units;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.TemplateMethod.Base.Attack
{
    public class MeleeAttack : WeaponAttack
    {
        protected override void DoAttackLogic(Unit unit)
        {
            unit.ReceiveDamage(_damage);
        }
    }
}