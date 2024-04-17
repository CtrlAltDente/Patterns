using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Composite.StarshipBlocks.Core
{
    public abstract class AttackBlock : MonoBehaviour
    {
        public abstract void Attack(Vector3 targetPosition);
    }
}