using Patterns.Composite.StarshipBlocks.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Composite.StarshipBlocks.AttackBlocks
{
    public class FrigateTurrelAttackBlock : AttackBlock
    {
        public override void Attack(Vector3 targetPosition)
        {
            Debug.Log("Frigate turrel attack command! Waiting for aiming operation complete");
        }
    }
}