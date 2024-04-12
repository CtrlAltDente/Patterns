using Patterns.StatePattern.UnitLogic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.StatePattern.StateLogic
{
    public class MoveState : State
    {
        public override void DoStateLogic(RaycastHit raycastHit, Unit unit)
        {
            if(raycastHit.collider.gameObject.layer == LayerMask.NameToLayer("Default"))
            {
                unit.MoveTo(raycastHit.point);
            }
        }
    }
}