using Patterns.Composite.StarshipBlocks.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Composite.StarshipBlocks.AttackBlocks
{
    public class StarshipGunAttackBlock : AttackBlock
    {
        public override void Attack(Vector3 targetPosition)
        {
            Debug.Log("Starship's guns are ready! Waiting for good aiming and close distance!");
        }
    }
}