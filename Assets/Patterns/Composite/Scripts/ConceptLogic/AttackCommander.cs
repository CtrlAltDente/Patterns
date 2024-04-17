using Patterns.Composite.StarshipBlocks.AttackBlocks;
using Patterns.Composite.StarshipBlocks.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Composite.ConceptLogic
{
    public class AttackCommander : MonoBehaviour
    {
        [SerializeField]
        private AttackBlock _unitAttackBlock;

        private void Start()
        {
            Attack(Vector3.zero);

        }

        private void Attack(Vector3 targetPosition)
        {
            _unitAttackBlock.Attack(targetPosition);
        }
    }
}