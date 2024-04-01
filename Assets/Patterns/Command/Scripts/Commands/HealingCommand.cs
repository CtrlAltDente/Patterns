using Patterns.CommandPattern.Base.TargetLogic;
using Patterns.CommandPattern.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.CommandPattern.Commands
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Patterns/Commands/HealingCommand", fileName = "HealingCommand_", order = 1)]
    public class HealingCommand : Command
    {
        [SerializeField]
        private int _healingValue;

        public override Groups CommandTarget => Groups.Ally;

        protected override void SpellLogic(ITarget target)
        {
            if(target.TargetGroup == CommandTarget)
            {
                Debug.Log($"Healed: {_healingValue}");
            }
            else
            {
                Debug.Log("Target not ally!");
            }
        }
    }
}