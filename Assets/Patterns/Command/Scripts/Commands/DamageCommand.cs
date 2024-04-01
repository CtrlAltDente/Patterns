using Patterns.CommandPattern.Base.TargetLogic;
using Patterns.CommandPattern.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.CommandPattern.Commands
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Patterns/Commands/DamageCommand", fileName = "DamageCommand_", order = 0)]
    public class DamageCommand : Command
    {
        [SerializeField]
        private int _damage;

        public override Groups CommandTarget => Groups.Enemy;

        protected override void SpellLogic(ITarget target)
        {
            if(target.TargetGroup == CommandTarget)
            {
                Debug.Log($"Damaged: {_damage}");
            }
            else
            {
                Debug.Log("Target isn't enemy!");
            }
        }
    }
}