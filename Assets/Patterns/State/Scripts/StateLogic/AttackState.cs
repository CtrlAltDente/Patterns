using Patterns.StatePattern.UnitLogic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.StatePattern.StateLogic
{
    public class AttackState : State
    {
        public override void DoStateLogic(RaycastHit raycastHit, Unit unit)
        {
            Debug.Log("Attack!");
        }
    }
}