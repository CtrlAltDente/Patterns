using Patterns.StatePattern.UnitLogic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.StatePattern.StateLogic
{
    public abstract class State : MonoBehaviour
    {
        public abstract void DoStateLogic(RaycastHit raycastHit, Unit unit);
    }
}