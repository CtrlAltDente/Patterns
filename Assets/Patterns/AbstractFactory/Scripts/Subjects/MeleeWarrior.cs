using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.AbstractFactory.Subjects
{
    public class MeleeWarrior : Subject
    {
        private void Start()
        {
            Health = 120;
        }

        public override void Attack()
        {
            Debug.Log("Melee attack");
        }
    }
}