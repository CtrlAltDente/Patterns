using Patterns.Composite.StarshipBlocks.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Composite.StarshipBlocks.AttackBlocks
{
    public class FrigateAttackBlock : AttackBlock
    {
        [SerializeField]
        private AttackBlock[] _attackBlocks;

        public override void Attack(Vector3 targetPosition)
        {
            Debug.Log("Frigate attack command! Moving to target!");

            foreach(var attackBlock in _attackBlocks)
            {
                attackBlock.Attack(targetPosition);
            }
        }
    }
}