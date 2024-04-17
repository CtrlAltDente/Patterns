using Patterns.Composite.StarshipBlocks.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Composite.StarshipBlocks.AttackBlocks
{
    public class StarshipAttackBlock : AttackBlock
    {
        [SerializeField]
        private AttackBlock[] _attackBlocks;

        public override void Attack(Vector3 targetPosition)
        {
            Debug.Log("Moving to target position!");

            foreach (AttackBlock attackBlock in _attackBlocks)
            {
                attackBlock.Attack(targetPosition);
            }
        }
    }
}