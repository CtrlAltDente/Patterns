using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.AbstractFactory.Subjects
{
    public class RangeWarrior : Subject
    {
        private void Start()
        {
            Health = 80;
        }

        public override void Attack()
        {
            Debug.Log("Ranged attack");
        }
    }
}